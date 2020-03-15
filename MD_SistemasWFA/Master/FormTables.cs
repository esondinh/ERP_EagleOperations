using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD_SistemasWFA.Master
{
    public partial class FormTables :  MetroForm
    {
        //TABLES
        public int MesaCantidad = 0;
        public int MesaSeleccionadaCantidad = 0;

        //THEME FORMS
        public MetroStyleManager MetroStryleManagerForm;

        //NEW
        System.Diagnostics.Process OSK;
        public FormTables()
        {
            InitializeComponent();
            //STYLE MANAGER
            MetroStryleManagerForm = new MetroStyleManager();
            StyleManager = metroStyleManager;

            //DATAGRIDVIEW 
            CreateTable();
        }

        #region CREATE TABLE
        private void CreateTable()
        {
            //DataTable tblTable = new DataTable();
            //tblTable.Columns.Add("N°");
            //tblTable.Columns.Add("Cantidad");
            //tblTable.Columns.Add("Estado");
            //tblTable.Rows.Add("01", "5", "Ocupada");
            //tblTable.Rows.Add("02", "3", "Disponible");
            //tblTable.Rows.Add("03", "2", "Ocupada");
            //tblTable.Rows.Add("04", "6", "Disponible");
            //tblTable.Rows.Add("05", "5", "Ocupada");
            //tblTable.Rows.Add("06", "5", "Disponible");
            //tblTable.Rows.Add("07", "4", "Ocupada");
            //tblTable.Rows.Add("08", "5", "Disponible");
            //tblTable.Rows.Add("09", "2", "Disponible");
            //tblTable.Rows.Add("10", "3", "Disponible");          

            DataGridViewComboBoxColumn dcombo = new DataGridViewComboBoxColumn();
            dcombo.HeaderText = "ComboBox";
            dcombo.Name = "ComboBox";
            dcombo.Items.Add("A");
            dcombo.Items.Add("B");
            dcombo.Items.Add("C");
            dcombo.Items.Add("D");

            DataGridViewButtonColumn dbtn = new DataGridViewButtonColumn();
            dbtn.UseColumnTextForButtonValue = true;
            dbtn.HeaderText = "Button";
            dbtn.Name = "Button";
            dbtn.Text = "Click me";
            DataGridViewCheckBoxColumn dcheck = new DataGridViewCheckBoxColumn();
            dcheck.HeaderText = "CheckBox";

            //METROTITLE
            //MetroTile mtitl = new MetroTile();
            //mtitl.Name = "Metro";
            //mtitl.Text = "Mtro";
            //mtitl.TextAlign = ContentAlignment.MiddleCenter;
            //tbl_Tables.Columns.Add(mtitl);

            //tbl_Tables.Columns.Add(dcombo);
            tbl_Tables.Columns.Add(dbtn);
            //tbl_Tables.Columns.Add(dcheck);
            Button btnTable = new Button();
            btnTable.Text = "aaa";
            btnTable.Name = "a";
            btnTable.UseCompatibleTextRendering = true;
            btnTable.BackColor = Color.Green;
            //Object[] row = new Object[] { 0, "01", "5", "Ocupada" , true};

            //Object[] row = new Object[] { 0, "01", "5", "Ocupada", btnTable };      
            //tbl_Tables.Rows.Add(row);
            //row = new Object[] { 1, "01", "5", "Disponible", btnTable };
            //tbl_Tables.Rows.Add(row);

            tbl_Tables.Rows.Insert(0, "01", "5", "Ocupada");
            tbl_Tables.Rows.Insert(1, "02", "3", "Disponible");
            tbl_Tables.Rows.Insert(2, "03", "2", "Ocupada");
            tbl_Tables.Rows.Insert(3, "04", "6", "Disponible");
            tbl_Tables.Rows.Insert(4, "05", "5", "Ocupada");
            tbl_Tables.Rows.Insert(5, "06", "5", "Disponible");
            tbl_Tables.Rows.Insert(6, "07", "4", "Ocupada");
            tbl_Tables.Rows.Insert(7, "08", "5", "Disponible");
            tbl_Tables.Rows.Insert(8, "09", "2", "Disponible");
            tbl_Tables.Rows.Insert(9, "10", "3", "Disponible");

            //COLOR CELLS
            ManagerResaltados(tbl_Tables, 1, Color.Green);

            //DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            //dimg.HeaderText = Properties.Resources.;
            //Image img = Image.FromFile(@"C:/Imgs/..");


        }

        #endregion

        private void tbl_Tables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string estado = (string)tbl_Tables.Rows[e.RowIndex].Cells[2].Value;
            if (estado == "Disponible")
            {
                MesaSeleccionadaCantidad = int.Parse(tbl_Tables.Rows[e.RowIndex].Cells[1].Value.ToString());
                ShowFormMessageNumbers sh_frm = new ShowFormMessageNumbers();

                //OPEN MODAL
                Form Modal = EffectModal();
                Modal.Show();

                //HIDE THIS FORM 
                this.Hide();

                DialogResult res = sh_frm.ShowDialog(); //abrimos el formulario 2 como cuadro de dialogo modal
                //RESULT PROCESS 

                if (res == DialogResult.OK)
                {
                    if (int.Parse(sh_frm.number) <= MesaSeleccionadaCantidad)
                    {
                        //DISPOSE MODAL
                        Modal.Dispose();
                        //OPEN FROMTABLESORDERS
                        FormTableOrdes frmOrders = new FormTableOrdes();
                        frmOrders.MesaCantidad = int.Parse(sh_frm.number);
                        frmOrders.Show();
                    }
                    else
                    {
                        var valNodisponible = int.Parse(sh_frm.number) - MesaSeleccionadaCantidad;
                        MetroMessageBox.Show(this, "La mesa seleccionada no dispone de " + valNodisponible + " asientos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
                        //DISPOSE MODAL
                        Modal.Dispose();
                        this.Show();

                    }
                }
                else if (res == DialogResult.Cancel)
                {
                    //DISPOSE MODAL
                    Modal.Dispose();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "La mesa esta " + estado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
            }
        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            metroStyleManager.Theme = MetroStryleManagerForm.Theme;
            metroStyleManager.Style = MetroStryleManagerForm.Style;
        }

        #region TXT_SEARCH...
        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt_Search = (MetroTextBox)sender;
            string search = txt_Search.Text;
            //METHOS FIND
            MetroGrid dtg = tbl_Tables;
            List<string[]> listTables = new List<string[]>();

            var celda = dtg.Rows[1].Cells[0].Value;
            for (int i = 0; i < dtg.RowCount; i++)
            {
                var a = dtg.Rows[i].Cells[0].Value.ToString();
                var b = dtg.Rows[i].Cells[1].Value.ToString();
                var c = dtg.Rows[i].Cells[2].Value.ToString();
                var d = dtg.Rows[i].Cells[3].DataGridView;
                listTables.Add(new string[4] { a, b, c, c });
            }


        }
        #endregion

        //

        #region EFECTOMODAL
        //EFECTO MODAL
        public Form EffectModal()
        {
            Form frmModal = new Form();
            frmModal.BackColor = Color.White;
            frmModal.Opacity = 0.6;
            frmModal.Width = 1366;
            frmModal.Height = 768;
            return frmModal;
        }


        #endregion

        #region CONFIGURATIONSCOLOSCELLS
        private void ManagerResaltados(MetroGrid visor, Int32 fila, Color c)
        {
            //visor.Rows[fila].Cells[0].Style.BackColor = c;
            //visor.Rows[fila].Cells[1].Style.BackColor = c;
            //visor.Rows[fila].Cells[2].Style.BackColor = c;
            //https://es.stackoverflow.com/questions/60502/ocultar-teclado-virtual-de-windows-aplicaci%C3%B3n-escritorio-c
            for (int i = 0; i < visor.RowCount - 1; i++)
            {
                if (visor.Rows[i].Cells[2].Value.ToString() == "Ocupada")
                {
                    visor.Rows[i].Cells[2].Style.BackColor = Color.LightCoral;
                    //buutons 4
                    DataGridViewButtonCell A = new DataGridViewButtonCell();
                    A.Value = visor.Rows[i].Cells[2].Value.ToString();
                    A.Style.BackColor = Color.LightCoral;
                    A.Style.ForeColor = Color.Red;
                    visor.Rows[i].Cells[4] = A;
                }
                else if (visor.Rows[i].Cells[2].Value.ToString() == "Disponible")
                {
                    DataGridViewButtonCell A = new DataGridViewButtonCell();
                    A.Value = visor.Rows[i].Cells[2].Value.ToString();
                    A.Style.BackColor = Color.YellowGreen;
                    A.Style.ForeColor = Color.Red;
                    visor.Rows[i].Cells[4] = A;
                }
            }
        }
        #endregion

        //TABLE_MESAS CELL CLICK
        private void tbl_Tables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                MetroMessageBox.Show(this, "YOU CLICKED" + e.RowIndex);
            }
        }

        #region (EVENT) BTN_CANCEL
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        #endregion

        //******************************METHODS***********************************\\

        private void button1_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            String keyboardPath = Path.Combine(progFiles, "TabTip.exe");
            Process.Start(keyboardPath);

            //OSK = Process.Start("osk.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OSK.Kill();
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
