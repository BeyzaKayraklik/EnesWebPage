
using DataBaseEntity.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEntity.DAO
{
    [Serializable]
    public class ProjectTblDAO  : ProjectTblBase
    {

        private DateTime dti;
        private Boolean b;
        private Decimal d;
        private int ii;
        private Int16 ii16;

        internal string Save()
        {
            string sqlcum = "";
            SqlParameter[] sqlparam;
            string fieldsName = "";
            string fieldsValue = "";
            int paramsayi = 0;
            int i = 0;

            if (this.Project_ID == null) this.Project_ID = 0;
            if (this.Project_ID == 0)
            {
                if (Project_Title != null)
                {
                    fieldsName += "Project_Title,";
                    fieldsValue += "@Project_Title,";
                    paramsayi++;
                }



                if (Project_Content != null)
                {
                    fieldsName += "Project_Content,";
                    fieldsValue += "@Project_Content,";
                    paramsayi++;
                }

                if (Project_Date != null)
                {
                    fieldsName += "Project_Date,";
                    fieldsValue += "@Project_Date,";
                    paramsayi++;
                }

                if (Project_Client != null)
                {
                    fieldsName += "Project_Client,";
                    fieldsValue += "@Project_Client,";
                    paramsayi++;
                }

                if (Project_URL != null)
                {
                    fieldsName += "Project_URL,";
                    fieldsValue += "@Project_URL,";
                    paramsayi++;
                }

                if (Project_Image != null)
                {
                    fieldsName += "Project_Image,";
                    fieldsValue += "@Project_Image,";
                    paramsayi++;
                }
                if (Project_Categori != null)
                {
                    fieldsName += "Project_Categori,";
                    fieldsValue += "@Project_Categori,";
                    paramsayi++;
                }
                if (Project_Status != null)
                {
                    fieldsName += "Project_Status,";
                    fieldsValue += "@Project_Status,";
                    paramsayi++;
                }



                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);
                fieldsValue = fieldsValue.Remove(fieldsValue.Length - 1, 1);


            }
            else
            {

                if (Project_Title != null)
                {
                    fieldsName += "Project_Title =@Project_Title ,";
                    paramsayi++;
                }


                if (Project_Content != null)
                {
                    fieldsName += "Project_Content=@Project_Content,";
                    paramsayi++;
                }

                if (Project_Date != null)
                {
                    fieldsName += "Project_Date=@Project_Date,";
                    paramsayi++;
                }

                if (Project_Client != null)
                {
                    fieldsName += "Project_Client=@Project_Client,";
                    paramsayi++;
                }

                if (Project_URL != null)
                {
                    fieldsName += "Project_URL=@Project_URL,";
                    paramsayi++;
                }

                if (Project_Image != null)
                {
                    fieldsName += "Project_Image=@Project_Image,";
                    paramsayi++;
                }

                if (Project_Categori != null)
                {
                    fieldsName += "Project_Categori=@Project_Categori,";
                    paramsayi++;
                }
                if (Project_Status != null)
                {
                    fieldsName += "Project_Status=@Project_Status,";
                    paramsayi++;
                }


                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);



            }

            sqlparam = new SqlParameter[paramsayi];


            while (paramsayi > i)
            {

                if (Project_Title != null)
                {
                    sqlparam[i] = new SqlParameter("@Project_Title", Project_Title);
                    i++;
                }
                if (Project_Content != null)
                {
                    sqlparam[i] = new SqlParameter("@Project_Content", Project_Content);
                    i++;
                }

                if (Project_Date != null)
                {
                    sqlparam[i] = new SqlParameter("@Project_Date", Project_Date);
                    i++;
                }

                if (Project_Client != null)
                {
                    sqlparam[i] = new SqlParameter("@Project_Client ", Project_Client);
                    i++;
                }

                if (Project_URL != null)
                {
                    sqlparam[i] = new SqlParameter("@Project_URL", Project_URL);
                    i++;
                }

                if (Project_Image != null)
                {
                    sqlparam[i] = new SqlParameter("@Project_Image", Project_Image);
                    i++;
                }
                if (Project_Categori != null)
                {
                    sqlparam[i] = new SqlParameter("@Project_Categori", Project_Categori);
                    i++;
                }
                if (Project_Status != null)
                {
                    sqlparam[i] = new SqlParameter("@Project_Status", Project_Status);
                    i++;
                }


            }

            if (this.Project_ID == 0)
            {
                sqlcum = "Insert INTO [ProjectTbl](" + fieldsName + ")Values(" + fieldsValue + ")";

                DbOperations.ParameterOperation(sqlcum, sqlparam);
                this.Project_ID = Convert.ToInt32(DbOperations.dtb("select max(Id) from [ProjectTbl]").Rows[0][0]);
                return "1";
            }
            else
            {
                sqlcum = "UPDATE [ProjectTbl] SET " + fieldsName + " where Id =" + this.Project_ID;
                DbOperations.ParameterOperation(sqlcum, sqlparam);
                return "2";
            }


        }

        internal string Delete(string _sql, params SqlParameter[] paramss)
        {
            DbOperations.ParameterOperation(_sql, paramss);
            return "3";
        }

        internal ProjectTblDAO Select(string sql_, params SqlParameter[] paramss)
        {

            ProjectTblDAO entity = new ProjectTblDAO();
            DataTable dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();

            if (columnNames.Contains("Project_ID")) entity.Project_ID = Convert.ToInt32(dt.Rows[0]["Project_ID"].ToString());
            if (columnNames.Contains("Project_Categori")) entity.Project_Categori = Convert.ToInt32(dt.Rows[0]["Project_Categori"].ToString());
            if (columnNames.Contains("Project_Title")) entity.Project_Title = dt.Rows[0]["Portfolio_Title"].ToString();
            if (columnNames.Contains("Project_Content")) entity.Project_Content = dt.Rows[0]["Project_Content"].ToString();
            if (columnNames.Contains("Project_Date"))
                entity.Project_Date = (DateTime?)dt.Rows[0]["Project_Date"];
            if (columnNames.Contains("Project_Client")) entity.Project_Client = dt.Rows[0]["Project_Client"].ToString();
            if (columnNames.Contains("Project_URL"))
                entity.Project_URL = dt.Rows[0]["Project_URL"].ToString();
            if (columnNames.Contains("Project_Image"))
                entity.Project_Image = dt.Rows[0]["Project_Image"].ToString();


            if (columnNames.Contains("Project_Status"))
                entity.Project_Status = (bool?)dt.Rows[0]["Project_Status "];

            return entity;
        } // okuma i�lemi bitiyor

        internal List<ProjectTblDAO> DataSource(string sql_, params SqlParameter[] paramss)
        {

            List<ProjectTblDAO> list = new List<ProjectTblDAO>();
            DataTable dt;
            if (paramss == null)
                dt = (DataTable)DbOperations.dtb(sql_);
            else
                dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);


            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            foreach (DataRow r in dt.Rows)
            {
                ProjectTblDAO entity = new ProjectTblDAO();

                if (columnNames.Contains("Project_ID")) entity.Project_ID = Convert.ToInt32(r["Project_ID"].ToString());
                if (columnNames.Contains("Project_Categori")) entity.Project_Categori = Convert.ToInt32(r["Project_Categori"].ToString());
                if (columnNames.Contains("Project_Title")) entity.Project_Title = r["Project_Title"].ToString();
                if (columnNames.Contains("Project_Content")) entity.Project_Content = r["Project_Content"].ToString();
                if (columnNames.Contains("Project_Date")) entity.Project_Date = (DateTime?)r["Project_Date"];
                if (columnNames.Contains("Project_Client")) entity.Project_Client = r["Project_Client"].ToString();
                if (columnNames.Contains("Project_URL"))
                    entity.Project_URL = r["Project_URL"].ToString();
                if (columnNames.Contains("Project_Image"))
                    entity.Project_Image = r["Project_Image"].ToString();

                if (columnNames.Contains("Project_Status"))
                    entity.Project_Status = (bool?)r["Project_Status"];


                list.Add(entity);
            }

            return list;
        }


    }
}
