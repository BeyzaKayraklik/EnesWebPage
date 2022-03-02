using DataBaseEntity.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEntity.Transaction
{
    [Serializable]
    public class ServicesTbl : ServicesTblDAO
    {


        public string Save(ServicesTblDAO tbl)
        {//kaydetme ba�lar
            try
            {
                return tbl.Save();
            }
            catch (Exception ex)
            {
                return ex.Message;

            }

        }//kaydetme biter

        public IEnumerable<object> ServicesTblDAO()
        {
            throw new NotImplementedException();
        }

        public string Delete(int Services_ID)
        {
            try
            {
                return new ServicesTblDAO().Delete("Delete From [ServicesTbl] where Services_ID=@Services_ID", new SqlParameter("@Services_ID", Services_ID));
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public ServicesTblDAO Select(int Services_ID)
        {
            return new ServicesTblDAO().Select("select * from [ServicesTbl] where Services_ID=@Services_ID", new SqlParameter("@Services_ID", Services_ID));
        }
        public ServicesTblDAO SelectExist(string Services_Title)
        {
            return new ServicesTblDAO().Select("select * from [ServicesTbl] where Services_Title=@Services_ID", new SqlParameter("@Services_ID", Services_Title));
        }

        public List<ServicesTblDAO> DataSource()
        {
            return new ServicesTblDAO().DataSource("select * from [ServicesTbl]");
        }
    }
}
