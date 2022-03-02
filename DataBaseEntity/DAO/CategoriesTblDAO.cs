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
    public class CategoriesTblDAO : CategoriesTblBase
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

                if (this.Categories_ID == null) this.Categories_ID = 0;
                if (this.Categories_ID == 0)
                {
                    if (Categories_Title != null)
                    {
                        fieldsName += "Categories_Title,";
                        fieldsValue += "@Categories_Title,";
                        paramsayi++;
                    }

                if (Categories_Image != null)
                {
                    fieldsName += "Categories_Image,";
                    fieldsValue += "@Categories_Image,";
                    paramsayi++;
                }



                if (Categories_Content != null)
                    {
                        fieldsName += "Categories_Content,";
                        fieldsValue += "@Categories_Content,";
                        paramsayi++;
                    }
                if (Categories_Status != null)
                {
                    fieldsName += "Categories_Status,";
                    fieldsValue += "@Categories_Status,";
                    paramsayi++;
                }


                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);
                    fieldsValue = fieldsValue.Remove(fieldsValue.Length - 1, 1);


                }
                else
                {

                    if (Categories_Title != null)
                    {
                        fieldsName += "Categories_Title =@Categories_Title ,";
                        paramsayi++;
                    }

                if (Categories_Image != null)
                {
                    fieldsName += "Categories_Image=@Categories_Image,";
                    paramsayi++;
                }


                if (Categories_Content != null)
                    {
                        fieldsName += "Categories_Content=@Categories_Content,";
                        paramsayi++;
                    }
                if (Categories_Status != null)
                {
                    fieldsName += "Categories_Status=@Categories_Status,";
                    paramsayi++;
                }

                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);



                }

                sqlparam = new SqlParameter[paramsayi];


                while (paramsayi > i)
                {

                    if (Categories_Title != null)
                    {
                        sqlparam[i] = new SqlParameter("@Categories_Title", Categories_Title);
                        i++;
                    }
                if (Categories_Image != null)
                {
                    sqlparam[i] = new SqlParameter("@Categories_Image", Categories_Image);
                    i++;
                }
                if (Categories_Content != null)
                    {
                        sqlparam[i] = new SqlParameter("@Categories_Content", Categories_Content);
                        i++;
                    }
                if (Categories_Status != null)
                {
                    sqlparam[i] = new SqlParameter("@Categories_Status", Categories_Status);
                    i++;
                }

            }

                if (this.Categories_ID == 0)
                {
                    sqlcum = "Insert INTO [CategoriesTbl](" + fieldsName + ")Values(" + fieldsValue + ")";

                    DbOperations.ParameterOperation(sqlcum, sqlparam);
                    this.Categories_ID = Convert.ToInt32(DbOperations.dtb("select max(Id) from [CategoriesTbl]").Rows[0][0]);
                    return "1";
                }
                else
                {
                    sqlcum = "UPDATE [CategoriesTbl] SET " + fieldsName + " where Id =" + this.Categories_ID;
                    DbOperations.ParameterOperation(sqlcum, sqlparam);
                    return "2";
                }


            }

            internal string Delete(string _sql, params SqlParameter[] paramss)
            {
                DbOperations.ParameterOperation(_sql, paramss);
                return "3";
            }

            internal CategoriesTblDAO Select(string sql_, params SqlParameter[] paramss)
            {

                CategoriesTblDAO entity = new CategoriesTblDAO();
                DataTable dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }

                string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();

                if (columnNames.Contains("Categories_ID")) entity.Categories_ID = Convert.ToInt32(dt.Rows[0]["Categories_ID"].ToString());
                if (columnNames.Contains("Categories_Title")) entity.Categories_Title = dt.Rows[0]["Categories_Title"].ToString();
                if (columnNames.Contains("Categories_Image")) entity.Categories_Image = dt.Rows[0]["Categories_Image"].ToString();
                if (columnNames.Contains("Categories_Content")) entity.Categories_Content = dt.Rows[0]["Categories_Content"].ToString();
                if (columnNames.Contains("Categories_Status")) entity.Categories_Status = (bool?)dt.Rows[0]["Categories_Status"];

            return entity;
            } // okuma i�lemi bitiyor

            internal List<CategoriesTblDAO> DataSource(string sql_, params SqlParameter[] paramss)
            {

                List<CategoriesTblDAO> list = new List<CategoriesTblDAO>();
                DataTable dt;
                if (paramss == null)
                    dt = (DataTable)DbOperations.dtb(sql_);
                else
                    dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);


                string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
                foreach (DataRow r in dt.Rows)
                {
                CategoriesTblDAO entity = new CategoriesTblDAO();

                    if (columnNames.Contains("Categories_ID")) entity.Categories_ID = Convert.ToInt32(r["Categories_ID"].ToString());
                    if (columnNames.Contains("Categories_Title")) entity.Categories_Title = r["Categories_Title"].ToString();
                if (columnNames.Contains("Categories_Image")) entity.Categories_Image = r["Categories_Image"].ToString();
                if (columnNames.Contains("Categories_Content")) entity.Categories_Content = r["Categories_Content"].ToString();
                if (columnNames.Contains("Categories_Status")) entity.Categories_Status = (bool?)r["Categories_Status"];

                list.Add(entity);
                }

                return list;
            }
        }

    }
