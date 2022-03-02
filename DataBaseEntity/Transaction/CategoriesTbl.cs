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
   public  class CategoriesTbl : CategoriesTblDAO
    {

        public string Save(CategoriesTblDAO tbl)
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

        public IEnumerable<object> CategoriesTblDAO()
        {
            throw new NotImplementedException();
        }

        public string Delete(int Categories_ID)
        {
            try
            {
                return new CategoriesTblDAO().Delete("Delete From [CategoriesTbl] where Categories_ID=@Categories_ID", new SqlParameter("@Categories_ID", Categories_ID));
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public CategoriesTblDAO Select(int Categories_ID)
        {
            return new CategoriesTblDAO().Select("select * from [CategoriesTbl] where Categories_ID=@Categories_ID", new SqlParameter("@Categories_ID", Categories_ID));
        }
        public CategoriesTblDAO SelectExist(string Categories_Title)
        {
            return new CategoriesTblDAO().Select("select * from [CategoriesTbl] where Categories_Title=@Categories_ID", new SqlParameter("@Categories_ID", Categories_Title));
        }

        public List<CategoriesTblDAO> DataSource()
        {
            return new CategoriesTblDAO().DataSource("select * from [CategoriesTbl]");
        }
    }
}

