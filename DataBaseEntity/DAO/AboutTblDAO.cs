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
    public class AboutTblDAO : AboutTblBase
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

            if (this.About_ID == null) this.About_ID = 0;
            if (this.About_ID == 0)
            {
                if (About_Title != null)
                {
                    fieldsName += "About_Title,";
                    fieldsValue += "@About_Title,";
                    paramsayi++;
                }



                if (About_Content != null)
                {
                    fieldsName += "About_Content,";
                    fieldsValue += "@About_Content,";
                    paramsayi++;
                }


                if (About_URL != null)
                {
                    fieldsName += "About_URL,";
                    fieldsValue += "@About_URL,";
                    paramsayi++;
                }

                if (About_Image != null)
                {
                    fieldsName += "About_Image,";
                    fieldsValue += "@About_Image,";
                    paramsayi++;
                }
                if (About_Social != null)
                {
                    fieldsName += "About_Social,";
                    fieldsValue += "@About_Social,";
                    paramsayi++;
                }

                if (About_Status != null)
                {
                    fieldsName += "About_Status,";
                    fieldsValue += "@About_Status,";
                    paramsayi++;
                }



                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);
                fieldsValue = fieldsValue.Remove(fieldsValue.Length - 1, 1);


            }
            else
            {

                if (About_Title != null)
                {
                    fieldsName += "About_Title =@About_Title ,";
                    paramsayi++;
                }


                if (About_Content != null)
                {
                    fieldsName += "About_Content=@About_Content,";
                    paramsayi++;
                }

               

                if (About_URL != null)
                {
                    fieldsName += "About_URL=@About_URL,";
                    paramsayi++;
                }

                if (About_Image != null)
                {
                    fieldsName += "About_Image=@About_Image,";
                    paramsayi++;
                }
                if (About_Social!= null)
                {
                    fieldsName += "About_Social=@About_Social,";
                    paramsayi++;
                }


                if (About_Status != null)
                {
                    fieldsName += "About_Status=@About_Status,";
                    paramsayi++;
                }


                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);



            }

            sqlparam = new SqlParameter[paramsayi];


            while (paramsayi > i)
            {

                if (About_Title != null)
                {
                    sqlparam[i] = new SqlParameter("@About_Title", About_Title);
                    i++;
                }
                if (About_Content != null)
                {
                    sqlparam[i] = new SqlParameter("@About_Content", About_Content);
                    i++;
                }

              

                if (About_URL != null)
                {
                    sqlparam[i] = new SqlParameter("@About_URL", About_URL);
                    i++;
                }

                if (About_Image != null)
                {
                    sqlparam[i] = new SqlParameter("@About_Image", About_Image);
                    i++;
                }

                if (About_Social != null)
                {
                    sqlparam[i] = new SqlParameter("@About_Social", About_Social);
                    i++;
                }

                if (About_Status != null)
                {
                    sqlparam[i] = new SqlParameter("@About_Status", About_Status);
                    i++;
                }


            }

            if (this.About_ID == 0)
            {
                sqlcum = "Insert INTO [AboutTbl](" + fieldsName + ")Values(" + fieldsValue + ")";

                DbOperations.ParameterOperation(sqlcum, sqlparam);
                this.About_ID = Convert.ToInt32(DbOperations.dtb("select max(Id) from [AboutTbl]").Rows[0][0]);
                return "1";
            }
            else
            {
                sqlcum = "UPDATE [AboutTbl] SET " + fieldsName + " where Id =" + this.About_ID;
                DbOperations.ParameterOperation(sqlcum, sqlparam);
                return "2";
            }


        }

        internal string Delete(string _sql, params SqlParameter[] paramss)
        {
            DbOperations.ParameterOperation(_sql, paramss);
            return "3";
        }

        internal AboutTblDAO Select(string sql_, params SqlParameter[] paramss)
        {

            AboutTblDAO entity = new AboutTblDAO();
            DataTable dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();

            if (columnNames.Contains("About_ID")) entity.About_ID = Convert.ToInt32(dt.Rows[0]["About_ID"].ToString());
           
            if (columnNames.Contains("About_Title")) entity.About_Title = dt.Rows[0]["About_Title"].ToString();
            if (columnNames.Contains("About_Content")) entity.About_Content = dt.Rows[0]["About_Content"].ToString();
            if (columnNames.Contains("About_Social")) entity.About_Social = dt.Rows[0]["About_Social"].ToString();

            if (columnNames.Contains("About_Image"))
                entity.About_Image = dt.Rows[0]["About_Image"].ToString();


            if (columnNames.Contains("About_Status"))
                entity.About_Status = (bool?)dt.Rows[0]["About_Status "];

            return entity;
        } // okuma i�lemi bitiyor

        internal List<AboutTblDAO> DataSource(string sql_, params SqlParameter[] paramss)
        {

            List<AboutTblDAO> list = new List<AboutTblDAO>();
            DataTable dt;
            if (paramss == null)
                dt = (DataTable)DbOperations.dtb(sql_);
            else
                dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);


            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            foreach (DataRow r in dt.Rows)
            {
                AboutTblDAO entity = new AboutTblDAO();

                if (columnNames.Contains("About_ID")) entity.About_ID = Convert.ToInt32(r["About_ID"].ToString());
               
                if (columnNames.Contains("About_Title")) entity.About_Title = r["About_Title"].ToString();
                if (columnNames.Contains("About_Content")) entity.About_Content = r["About_Content"].ToString();
                if (columnNames.Contains("About_Social")) entity.About_Social = r["About_Social"].ToString();
                if (columnNames.Contains("About_Image"))
                    entity.About_Image = r["About_Image"].ToString();

                if (columnNames.Contains("About_Status"))
                    entity.About_Status = (bool?)r["About_Status"];


                list.Add(entity);
            }

            return list;
        }

    }
}
