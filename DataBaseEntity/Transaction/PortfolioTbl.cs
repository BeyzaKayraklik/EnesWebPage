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
    public  class PortfolioTbl : PortfolioTblDAO
    {

        public string Save(PortfolioTblDAO tbl)
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

        public IEnumerable<object> PortfolioTblDAO()
        {
            throw new NotImplementedException();
        }

        public string Delete(int Portfolio_ID)
        {
            try
            {
                return new PortfolioTblDAO().Delete("Delete From [PortfolioTbl] where Portfolio_ID=@Portfolio_ID", new SqlParameter("@Portfolio_ID", Portfolio_ID));
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public PortfolioTblDAO Select(int Portfolio_ID)
        {
            return new PortfolioTblDAO().Select("select * from [PortfolioTbl] where Portfolio_ID=@Portfolio_ID", new SqlParameter("@Portfolio_ID", Portfolio_ID));
        }
        public PortfolioTblDAO SelectExist(string tc)
        {
            return new PortfolioTblDAO().Select("select * from [PortfolioTbl] where tc=@Id", new SqlParameter("@Id", tc));
        }

        public List<PortfolioTblDAO> DataSource(int Portfolio_Categori)
        {
            return new PortfolioTblDAO().DataSource("select * from [PortfolioTbl] where Portfolio_Categori=@Portfolio_Categori", new SqlParameter("@Portfolio_Categori", Portfolio_Categori));
        }
     

    }

}

