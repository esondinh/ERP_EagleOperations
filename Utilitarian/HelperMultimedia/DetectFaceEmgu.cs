﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
#if !(__IOS__ || NETFX_CORE)
using Emgu.CV.Cuda;
#endif

namespace Utilitarian.HelperMultimedia
{
    //public static class DetectFaceEmgu
    public class DetectFaceEmgu
    {
        //Variable
        public List<Rectangle> Faces = null;

        public static void Detect(
           IInputArray image, String faceFileName, String eyeFileName,
           List<Rectangle> faces, List<Rectangle> eyes,
           out long detectionTime)
        {
            Stopwatch watch;
            //da errro ver mas tarde
            using (InputArray iaImage = image.GetInputArray())
            {

#if !(__IOS__ || NETFX_CORE)
                if (iaImage.Kind == InputArray.Type.CudaGpuMat && CudaInvoke.HasCuda)
                {
                    using (CudaCascadeClassifier face = new CudaCascadeClassifier(faceFileName))
                    using (CudaCascadeClassifier eye = new CudaCascadeClassifier(eyeFileName))
                    {
                        face.ScaleFactor = 1.1;
                        face.MinNeighbors = 10;
                        face.MinObjectSize = Size.Empty;
                        eye.ScaleFactor = 1.1;
                        eye.MinNeighbors = 10;
                        eye.MinObjectSize = Size.Empty;
                        watch = Stopwatch.StartNew();
                        using (CudaImage<Bgr, Byte> gpuImage = new CudaImage<Bgr, byte>(image))
                        using (CudaImage<Gray, Byte> gpuGray = gpuImage.Convert<Gray, Byte>())
                        using (GpuMat region = new GpuMat())
                        {
                            face.DetectMultiScale(gpuGray, region);
                            Rectangle[] faceRegion = face.Convert(region);
                            faces.AddRange(faceRegion);
                            foreach (Rectangle f in faceRegion)
                            {
                                using (CudaImage<Gray, Byte> faceImg = gpuGray.GetSubRect(f))
                                {
                                    //For some reason a clone is required.
                                    //Might be a bug of CudaCascadeClassifier in opencv
                                    using (CudaImage<Gray, Byte> clone = faceImg.Clone(null))
                                    using (GpuMat eyeRegionMat = new GpuMat())
                                    {
                                        eye.DetectMultiScale(clone, eyeRegionMat);
                                        Rectangle[] eyeRegion = eye.Convert(eyeRegionMat);
                                        foreach (Rectangle e in eyeRegion)
                                        {
                                            Rectangle eyeRect = e;
                                            eyeRect.Offset(f.X, f.Y);
                                            eyes.Add(eyeRect);
                                        }
                                    }
                                }
                            }
                        }
                        watch.Stop();
                    }
                }
                else
#endif
                {
                    //Read the HaarCascade objects
                    using (CascadeClassifier face = new CascadeClassifier(faceFileName))
                    using (CascadeClassifier eye = new CascadeClassifier(eyeFileName))
                    {
                        watch = Stopwatch.StartNew();

                        using (UMat ugray = new UMat())
                        {
                            CvInvoke.CvtColor(image, ugray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

                            //normalizes brightness and increases contrast of the image
                            CvInvoke.EqualizeHist(ugray, ugray);

                            //Detect the faces  from the gray scale image and store the locations as rectangle
                            //The first dimensional is the channel
                            //The second dimension is the index of the rectangle in the specific channel                     
                            Rectangle[] facesDetected = face.DetectMultiScale(
                               ugray,
                               1.1,
                               10,
                               new Size(20, 20));

                            faces.AddRange(facesDetected);

                            foreach (Rectangle f in facesDetected)
                            {
                                //Get the region of interest on the faces
                                using (UMat faceRegion = new UMat(ugray, f))
                                {
                                    Rectangle[] eyesDetected = eye.DetectMultiScale(
                                       faceRegion,
                                       1.1,
                                       10,
                                       new Size(20, 20));

                                    foreach (Rectangle e in eyesDetected)
                                    {
                                        Rectangle eyeRect = e;
                                        eyeRect.Offset(f.X, f.Y);
                                        eyes.Add(eyeRect);
                                    }
                                }
                            }
                        }
                        watch.Stop();
                    }
                }
                detectionTime = watch.ElapsedMilliseconds;
            }
        }


        //
        #region RecognitionFace
        public Image FaceRecognition(Image imagenCamaraWeb)
        {
            try
            {
                Bitmap newBmp = new Bitmap(imagenCamaraWeb);
                newBmp.Save("default.jpg");
                //imagenCamaraWeb.Save("default.jpg");

                if (File.Exists("default.jpg"))
                {
                    IImage image;
                    //Read the files as an 8-bit Bgr image  
                    image = new Mat("default.jpg", ImreadModes.Color); //CPU version
                    //image = new UMat("img1.jpg", ImreadModes.Color); //UMat version

                    long detectionTime;
                    List<Rectangle> faces = new List<Rectangle>();
                    List<Rectangle> eyes = new List<Rectangle>();

                    DetectFaceEmgu.Detect(
                      image, "haarcascade_frontalface_default.xml", "haarcascade_eye.xml",
                      faces, eyes,
                      out detectionTime);

                    foreach (Rectangle face in faces)
                        CvInvoke.Rectangle(image, face, new Bgr(Color.Red).MCvScalar, 2);
                    foreach (Rectangle eye in eyes)
                        CvInvoke.Rectangle(image, eye, new Bgr(Color.Blue).MCvScalar, 2);

                    //display the image 
                    //InputArray iaImage = image.GetInputArray();

                    //start custom code                 
                    if (faces.Count>0)
                    {
                        Faces = faces;
                        imagenCamaraWeb = image.Bitmap;
                    }
                    //string detail = String.Format(
                    //   "Completed face and eye detection using {0} in {1} milliseconds",
                    //   (iaImage.Kind == InputArray.Type.CudaGpuMat && CudaInvoke.HasCuda) ? "CUDA" :
                    //   (iaImage.IsUMat && CvInvoke.UseOpenCL) ? "OpenCL"
                    //   : "CPU",
                    //   detectionTime);
                    //imagenCamaraWeb.Tag = detail;
                    //end custom code                 
                }
                return imagenCamaraWeb;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void ReplaceFile(string FileToMoveAndDelete, string FileToReplace, string BackupOfFileToReplace)
        {
            File.Replace(FileToMoveAndDelete, FileToReplace, BackupOfFileToReplace, false);

        }
        #endregion
    }

}
