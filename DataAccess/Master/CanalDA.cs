using BusinessEntities;
using BusinessEntities.Connectionn;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarian;
using Dapper;
using System.Configuration;

namespace DataAccess.Master
{
    public class CanalDA
    {
        private EagleContext dbContext = new EagleContext();

        public List<MSTt04_canal_vta> ListCanal(int? id_estado = null)
        {
            var lista = new List<MSTt04_canal_vta>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt04_canal_vta" :
                @"SELECT * FROM MSTt04_canal_vta WHERE id_estado=@id_estado";
            //using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            using (var cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["EagleContext"].ConnectionString))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt04_canal_vta>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                     var log = new Log();
                     log.ArchiveLog("Lista Canal: ", e.Message);
                }
            }
            return lista;
        }


        // //////////////////////////////////////////////////////
        //(METHOD) RETURN ALL LIST OF CANALES
        public List<MSTt04_canal_vta> GetCanals()
        {
            var ListCanales = dbContext.MSTt04_canal_vta.ToList();
            return ListCanales;
        }
        //(METHOD) RETURN ALL LIST OF CANALES
        public static List<MSTt04_canal_vta> GetCanals2()
        {
            List<MSTt04_canal_vta> lstMSTt04_canal_vta = null;
            using (EagleContext db = new EagleContext())
            {
                lstMSTt04_canal_vta = (from u in db.MSTt04_canal_vta select u).ToList();
            }
            return lstMSTt04_canal_vta;
        }
    }
}
