using BusinessEntities;
using DataAccess.Master; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Master
{
    public class CanalBL
    {
        CanalDA objCanalDA = new CanalDA();

        //(METHOS) RETURN ALL OR A SIGLE CHANNEL DATA LIST
        public List<MSTt04_canal_vta> ListCanal(int? id_estado = null)
        {
            return new CanalDA().ListCanal(id_estado);
        }

        //(METHOD) RETURN ALL LIST OF CANALES
        public List<MSTt04_canal_vta> GetCanals()
        {
            return objCanalDA.GetCanals();
        }

        //(METHOD) RETURN ALL LIST OF CANALES
        public List<MSTt04_canal_vta> GetCanals2()
        {
            return objCanalDA.GetCanals();
        }
    }
}
