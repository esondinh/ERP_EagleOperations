using BusinessEntities;
using DataAccess.Person;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Person
{
    public class UserBL
    {
        public List<PERt01_usuario> GetAllOrASingleUser(string cod_usuario = "")
        {
            return new UserDA().GetAllOrASingleUser(cod_usuario);
        }
    }
}
