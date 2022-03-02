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
    public  class AboutTbl : AboutTblDAO
    {


        public string Save(AboutTblDAO tbl)
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

        public IEnumerable<object> AboutTblDAO()
        {
            throw new NotImplementedException();
        }

        public string Delete(int About_ID)
        {
            try
            {
                return new AboutTblDAO().Delete("Delete From [AboutTbl] where About_ID=@About_ID", new SqlParameter("@About_ID", About_ID));
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public AboutTblDAO Select(int About_ID)
        {
            return new AboutTblDAO().Select("select * from [AboutTbl] where About_ID=@About_ID", new SqlParameter("@About_ID", About_ID));
        }
        public AboutTblDAO SelectExist(string tc)
        {
            return new AboutTblDAO().Select("select * from [AboutTbl] where tc=@Id", new SqlParameter("@Id", tc));
        }

        public List<AboutTblDAO> DataSource()
        {
            return new AboutTblDAO().DataSource("select * from [AboutTbl]");
        }

    }
}
