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
    public  class SliderTblDAO : SliderTblBase
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

            if (this.Slider_ID == null) this.Slider_ID = 0;
            if (this.Slider_ID == 0)
            {
                if (Slider_Title != null)
                {
                    fieldsName += "Slider_Title,";
                    fieldsValue += "@Slider_Title,";
                    paramsayi++;
                }


                if (Slider_Content != null)
                {
                    fieldsName += "Slider_Content,";
                    fieldsValue += "@Slider_Content,";
                    paramsayi++;
                }

              

                if (Slider_Image != null)
                {
                    fieldsName += "Slider_Image,";
                    fieldsValue += "@Slider_Image,";
                    paramsayi++;
                }
               
                if (Slider_Status != null)
                {
                    fieldsName += "Slider_Status,";
                    fieldsValue += "@Slider_Status,";
                    paramsayi++;
                }



                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);
                fieldsValue = fieldsValue.Remove(fieldsValue.Length - 1, 1);


            }
            else
            {

                if (Slider_Title != null)
                {
                    fieldsName += "Slider_Title =@Slider_Title ,";
                    paramsayi++;
                }


                if (Slider_Content != null)
                {
                    fieldsName += "Slider_Content=@Slider_Content,";
                    paramsayi++;
                }

                if (Slider_Image != null)
                {
                    fieldsName += "Slider_Image=@Slider_Image,";
                    paramsayi++;
                }

              
                if (Slider_Status != null)
                {
                    fieldsName += "Slider_Status=@Slider_Status,";
                    paramsayi++;
                }


                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);



            }

            sqlparam = new SqlParameter[paramsayi];


            while (paramsayi > i)
            {

                if (Slider_Title != null)
                {
                    sqlparam[i] = new SqlParameter("@Slider_Title", Slider_Title);
                    i++;
                }
                if (Slider_Content != null)
                {
                    sqlparam[i] = new SqlParameter("@Slider_Content", Slider_Content);
                    i++;
                }

              
                if (Slider_Image != null)
                {
                    sqlparam[i] = new SqlParameter("@Slider_Image", Slider_Image);
                    i++;
                }
              
                if (Slider_Status != null)
                {
                    sqlparam[i] = new SqlParameter("@Slider_Status", Slider_Status);
                    i++;
                }


            }

            if (this.Slider_ID == 0)
            {
                sqlcum = "Insert INTO [SliderTbl](" + fieldsName + ")Values(" + fieldsValue + ")";

                DbOperations.ParameterOperation(sqlcum, sqlparam);
                this.Slider_ID = Convert.ToInt32(DbOperations.dtb("select max(Id) from [SliderTbl]").Rows[0][0]);
                return "1";
            }
            else
            {
                sqlcum = "UPDATE [SliderTbl] SET " + fieldsName + " where Id =" + this.Slider_ID;
                DbOperations.ParameterOperation(sqlcum, sqlparam);
                return "2";
            }


        }

        internal string Delete(string _sql, params SqlParameter[] paramss)
        {
            DbOperations.ParameterOperation(_sql, paramss);
            return "3";
        }

        internal SliderTblDAO Select(string sql_, params SqlParameter[] paramss)
        {

            SliderTblDAO entity = new SliderTblDAO();
            DataTable dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();

            if (columnNames.Contains("Slider_ID")) entity.Slider_ID = Convert.ToInt32(dt.Rows[0]["Slider_ID"].ToString());
            
            if (columnNames.Contains("Slider_Title")) entity.Slider_Title = dt.Rows[0]["Slider_Title"].ToString();
            if (columnNames.Contains("Slider_Content")) entity.Slider_Content = dt.Rows[0]["Slider_Content"].ToString();
           
            if (columnNames.Contains("Slider_Image"))
                entity.Slider_Image = dt.Rows[0]["Slider_Image"].ToString();


            if (columnNames.Contains("Slider_Status"))
                entity.Slider_Status = (bool?)dt.Rows[0]["Slider_Status "];

            return entity;
        } // okuma i�lemi bitiyor

        internal List<SliderTblDAO> DataSource(string sql_, params SqlParameter[] paramss)
        {

            List<SliderTblDAO> list = new List<SliderTblDAO>();
            DataTable dt;
            if (paramss == null)
                dt = (DataTable)DbOperations.dtb(sql_);
            else
                dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);


            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            foreach (DataRow r in dt.Rows)
            {
                SliderTblDAO entity = new SliderTblDAO();

                if (columnNames.Contains("Slider_ID")) entity.Slider_ID = Convert.ToInt32(r["Slider_ID"].ToString());

                if (columnNames.Contains("Slider_Title")) entity.Slider_Title = r["Slider_Title"].ToString();
                if (columnNames.Contains("Slider_Content")) entity.Slider_Content = r["Slider_Content"].ToString();
          
                if (columnNames.Contains("Slider_Image"))
                    entity.Slider_Image = r["Slider_Image"].ToString();

                if (columnNames.Contains("Slider_Status"))
                    entity.Slider_Status = (bool?)r["Slider_Status"];


                list.Add(entity);
            }

            return list;
        }
    }
}
