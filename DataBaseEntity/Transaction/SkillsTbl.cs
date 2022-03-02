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
    public class SkillsTbl : SkillsTblDAO 
    {

        public string Save(SkillsTblDAO tbl)
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

        public IEnumerable<object> SkillsTblDAO()
        {
            throw new NotImplementedException();
        }

        public string Delete(int Skills_ID)
        {
            try
            {
                return new SkillsTblDAO().Delete("Delete From [SkillsTbl] where Skills_ID=@Skills_ID", new SqlParameter("@Skills_ID", Skills_ID));
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public SkillsTblDAO Select(int Skills_ID)
        {
            return new SkillsTblDAO().Select("select * from [SkillsTbl] where Skills_ID=@Skills_ID", new SqlParameter("@Skills_ID", Skills_ID));
        }
        public SkillsTblDAO SelectExist(string Skills_Title)
        {
            return new SkillsTblDAO().Select("select * from [SkillsTbl] where Skills_Title=@Skills_ID", new SqlParameter("@Skills_ID", Skills_Title));
        }

        public List<SkillsTblDAO> DataSource()
        {
            return new SkillsTblDAO().DataSource("select * from [SkillsTbl]");
        }

    }
}
