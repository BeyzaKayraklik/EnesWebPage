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
    public class ServicesTblDAO : ServicesTblBase
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

            if (this.Services_ID == null) this.Services_ID = 0;
            if (this.Services_ID == 0)
            {
                if (Services_Title != null)
                {
                    fieldsName += "Services_Title,";
                    fieldsValue += "@Services_Title,";
                    paramsayi++;
                }

               


                if (Services_Content != null)
                {
                    fieldsName += "Services_Content,";
                    fieldsValue += "@Services_Content,";
                    paramsayi++;
                }
                if (Services_Status != null)
                {
                    fieldsName += "Services_Status,";
                    fieldsValue += "@Services_Status,";
                    paramsayi++;
                }


                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);
                fieldsValue = fieldsValue.Remove(fieldsValue.Length - 1, 1);


            }
            else
            {

                if (Services_Title != null)
                {
                    fieldsName += "Services_Title =@Services_Title ,";
                    paramsayi++;
                }

            
                if (Services_Content != null)
                {
                    fieldsName += "Services_Content=@Services_Content,";
                    paramsayi++;
                }
                if (Services_Status != null)
                {
                    fieldsName += "Services_Status=@Services_Status,";
                    paramsayi++;
                }

                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);



            }

            sqlparam = new SqlParameter[paramsayi];


            while (paramsayi > i)
            {

                if (Services_Title != null)
                {
                    sqlparam[i] = new SqlParameter("@Services_Title", Services_Title);
                    i++;
                }
              
                if (Services_Content != null)
                {
                    sqlparam[i] = new SqlParameter("@Services_Content", Services_Content);
                    i++;
                }
                if (Services_Status != null)
                {
                    sqlparam[i] = new SqlParameter("@Services_Status", Services_Status);
                    i++;
                }

            }

            if (this.Services_ID == 0)
            {
                sqlcum = "Insert INTO [ServicesTbl](" + fieldsName + ")Values(" + fieldsValue + ")";

                DbOperations.ParameterOperation(sqlcum, sqlparam);
                this.Services_ID = Convert.ToInt32(DbOperations.dtb("select max(Id) from [ServicesTbl]").Rows[0][0]);
                return "1";
            }
            else
            {
                sqlcum = "UPDATE [ServicesTbl] SET " + fieldsName + " where Id =" + this.Services_ID;
                DbOperations.ParameterOperation(sqlcum, sqlparam);
                return "2";
            }


        }

        internal string Delete(string _sql, params SqlParameter[] paramss)
        {
            DbOperations.ParameterOperation(_sql, paramss);
            return "3";
        }

        internal ServicesTblDAO Select(string sql_, params SqlParameter[] paramss)
        {

            ServicesTblDAO entity = new ServicesTblDAO();
            DataTable dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();

            if (columnNames.Contains("Services_ID")) entity.Services_ID = Convert.ToInt32(dt.Rows[0]["Services_ID"].ToString());
            if (columnNames.Contains("Services_Title")) entity.Services_Title = dt.Rows[0]["Services_Title"].ToString();
         
            if (columnNames.Contains("Services_Content")) entity.Services_Content = dt.Rows[0]["Services_Content"].ToString();
            if (columnNames.Contains("Services_Status")) entity.Services_Status = (bool?)dt.Rows[0]["Services_Status"];

            return entity;
        } // okuma i�lemi bitiyor

        internal List<ServicesTblDAO> DataSource(string sql_, params SqlParameter[] paramss)
        {

            List<ServicesTblDAO> list = new List<ServicesTblDAO>();
            DataTable dt;
            if (paramss == null)
                dt = (DataTable)DbOperations.dtb(sql_);
            else
                dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);


            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            foreach (DataRow r in dt.Rows)
            {
                ServicesTblDAO entity = new ServicesTblDAO();

                if (columnNames.Contains("Services_ID")) entity.Services_ID = Convert.ToInt32(r["Services_ID"].ToString());
                if (columnNames.Contains("Services_Title")) entity.Services_Title = r["Services_Title"].ToString();

                if (columnNames.Contains("Services_Content")) entity.Services_Content = r["Services_Content"].ToString();
                if (columnNames.Contains("Services_Status")) entity.Services_Status = (bool?)r["Services_Status"];

                list.Add(entity);
            }

            return list;
        }


    }
}
