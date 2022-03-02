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
     public class ProjectTbl : ProjectTblDAO
    {
        public string Save(ProjectTblDAO tbl)
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

        public IEnumerable<object> ProjectTblDAO()
        {
            throw new NotImplementedException();
        }

        public string Delete(int Project_ID)
        {
            try
            {
                return new ProjectTblDAO().Delete("Delete From [ProjectTbl] where Project_ID=@Project_ID", new SqlParameter("@Project_ID", Project_ID));
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public ProjectTblDAO Select(int Project_ID)
        {
            return new ProjectTblDAO().Select("select * from [ProjectTbl] where Project_ID=@Project_ID", new SqlParameter("@Project_ID", Project_ID));
        }
        public ProjectTblDAO SelectExist(string tc)
        {
            return new ProjectTblDAO().Select("select * from [ProjectTbl] where tc=@Id", new SqlParameter("@Id", tc));
        }

        public List<ProjectTblDAO> DataSource()
        {
            return new ProjectTblDAO().DataSource("select * from [ProjectTbl]");
        }

    }

}

