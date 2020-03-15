using Utilitarian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Connectionn
{
    public class ConnectionManager
    {
        public static string GetConnectionString()
        {
            string strCn = "";
            try
            {
                strCn = Connection.GetAppConnectionString();
            }
            catch (Exception e)
            {
                var log = new Log();
                log.ArchiveLog("Entity. Get Connection String: ", e.Message);
            }
            return strCn;
        }
    }
}
