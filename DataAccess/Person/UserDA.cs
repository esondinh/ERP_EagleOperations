using BusinessEntities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarian;

namespace DataAccess.Person
{
    public class UserDA
    {
        public List<PERt01_usuario> GetAllOrASingleUser(string cod_usuario = "")
        {
            var lista = new List<PERt01_usuario>();
            string sentencia = string.Empty;
            sentencia = (cod_usuario == "") ?
                @"SELECT * FROM PERt01_usuario" :
                @"SELECT * FROM PERt01_usuario WHERE cod_usuario=@cod_usuario";
            //using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            using (var cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["EagleContext"].ConnectionString))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PERt01_usuario>(sentencia, new { cod_usuario }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Usuario: ", e.Message);
                }
            }
            return lista;
        }
    }
}
