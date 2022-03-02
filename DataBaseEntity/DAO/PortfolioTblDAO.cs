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

    public class PortfolioTblDAO : PortfolioTblBase
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

            if (this.Portfolio_ID == null) this.Portfolio_ID = 0;
            if (this.Portfolio_ID == 0)
            {
                if (Portfolio_Title != null)
                {
                    fieldsName += "Portfolio_Title,";
                    fieldsValue += "@Portfolio_Title,";
                    paramsayi++;
                }



                if (Portfolio_Content != null)
                {
                    fieldsName += "Portfolio_Content,";
                    fieldsValue += "@Portfolio_Content,";
                    paramsayi++;
                }

                if (Portfolio_Date != null)
                {
                    fieldsName += "Portfolio_Date,";
                    fieldsValue += "@Portfolio_Date,";
                    paramsayi++;
                }

                if (Portfolio_Client != null)
                {
                    fieldsName += "Portfolio_Client,";
                    fieldsValue += "@Portfolio_Client,";
                    paramsayi++;
                }

                if (Portfolio_URL != null)
                {
                    fieldsName += "Portfolio_URL,";
                    fieldsValue += "@Portfolio_URL,";
                    paramsayi++;
                }

                if (Portfolio_Image != null)
                {
                    fieldsName += "Portfolio_Image,";
                    fieldsValue += "@Portfolio_Image,";
                    paramsayi++;
                }
                if (Portfolio_Categori != null)
                {
                    fieldsName += "Portfolio_Categori,";
                    fieldsValue += "@Portfolio_Categori,";
                    paramsayi++;
                }
                if (Portfolio_Status != null)
                {
                    fieldsName += "Portfolio_Status,";
                    fieldsValue += "@Portfolio_Status,";
                    paramsayi++;
                }



                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);
                fieldsValue = fieldsValue.Remove(fieldsValue.Length - 1, 1);


            }
            else
            {

                if (Portfolio_Title != null)
                {
                    fieldsName += "Portfolio_Title =@Portfolio_Title ,";
                    paramsayi++;
                }


                if (Portfolio_Content != null)
                {
                    fieldsName += "Portfolio_Content=@Portfolio_Content,";
                    paramsayi++;
                }

                if (Portfolio_Date != null)
                {
                    fieldsName += "Portfolio_Date=@Portfolio_Date,";
                    paramsayi++;
                }

                if (Portfolio_Client != null)
                {
                    fieldsName += "Portfolio_Client=@Portfolio_Client,";
                    paramsayi++;
                }

                if (Portfolio_URL != null)
                {
                    fieldsName += "Portfolio_URL=@Portfolio_URL,";
                    paramsayi++;
                }

                if (Portfolio_Image != null)
                {
                    fieldsName += "Portfolio_Image=@Portfolio_Image,";
                    paramsayi++;
                }

                if (Portfolio_Categori != null)
                {
                    fieldsName += "Portfolio_Categori=@Portfolio_Categori,";
                    paramsayi++;
                }
                if (Portfolio_Status != null)
                {
                    fieldsName += "Portfolio_Status=@Portfolio_Status,";
                    paramsayi++;
                }


                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);



            }

            sqlparam = new SqlParameter[paramsayi];


            while (paramsayi > i)
            {

                if (Portfolio_Title != null)
                {
                    sqlparam[i] = new SqlParameter("@Portfolio_Title", Portfolio_Title);
                    i++;
                }
                if (Portfolio_Content != null)
                {
                    sqlparam[i] = new SqlParameter("@Portfolio_Content", Portfolio_Content);
                    i++;
                }

                if (Portfolio_Date != null)
                {
                    sqlparam[i] = new SqlParameter("@Portfolio_Date", Portfolio_Date);
                    i++;
                }

                if (Portfolio_Client != null)
                {
                    sqlparam[i] = new SqlParameter("@Portfolio_Client ", Portfolio_Client);
                    i++;
                }

                if (Portfolio_URL != null)
                {
                    sqlparam[i] = new SqlParameter("@Portfolio_URL", Portfolio_URL);
                    i++;
                }

                if (Portfolio_Image != null)
                {
                    sqlparam[i] = new SqlParameter("@Portfolio_Image", Portfolio_Image);
                    i++;
                }
                if (Portfolio_Categori != null)
                {
                    sqlparam[i] = new SqlParameter("@Portfolio_Categori", Portfolio_Categori);
                    i++;
                }
                if (Portfolio_Status != null)
                {
                    sqlparam[i] = new SqlParameter("@Portfolio_Status", Portfolio_Status);
                    i++;
                }


            }

            if (this.Portfolio_ID == 0)
            {
                sqlcum = "Insert INTO [PortfolioTbl](" + fieldsName + ")Values(" + fieldsValue + ")";

                DbOperations.ParameterOperation(sqlcum, sqlparam);
                this.Portfolio_ID = Convert.ToInt32(DbOperations.dtb("select max(Id) from [PortfolioTbl]").Rows[0][0]);
                return "1";
            }
            else
            {
                sqlcum = "UPDATE [PortfolioTbl] SET " + fieldsName + " where Id =" + this.Portfolio_ID;
                DbOperations.ParameterOperation(sqlcum, sqlparam);
                return "2";
            }


        }

        internal string Delete(string _sql, params SqlParameter[] paramss)
        {
            DbOperations.ParameterOperation(_sql, paramss);
            return "3";
        }

        internal PortfolioTblDAO Select(string sql_, params SqlParameter[] paramss)
        {

            PortfolioTblDAO entity = new PortfolioTblDAO();
            DataTable dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();

            if (columnNames.Contains("Portfolio_ID")) entity.Portfolio_ID = Convert.ToInt32(dt.Rows[0]["Portfolio_ID"].ToString());
            if (columnNames.Contains("Portfolio_Categori")) entity.Portfolio_Categori = Convert.ToInt32(dt.Rows[0]["Portfolio_Categori"].ToString());
            if (columnNames.Contains("Portfolio_Title")) entity.Portfolio_Title = dt.Rows[0]["Portfolio_Title"].ToString();
            if (columnNames.Contains("Portfolio_Content")) entity.Portfolio_Content = dt.Rows[0]["Portfolio_Content"].ToString();
            if (columnNames.Contains("Portfolio_Date"))
                entity.Portfolio_Date = (DateTime?)dt.Rows[0]["Portfolio_Date"];
            if (columnNames.Contains("Portfolio_Client")) entity.Portfolio_Client = dt.Rows[0]["Portfolio_Client"].ToString();
            if (columnNames.Contains("Portfolio_URL"))
                entity.Portfolio_URL = dt.Rows[0]["Portfolio_URL"].ToString();
            if (columnNames.Contains("Portfolio_Image"))
                entity.Portfolio_Image = dt.Rows[0]["Portfolio_Image"].ToString();

           
            if (columnNames.Contains("Portfolio_Status"))
                entity.Portfolio_Status = (bool?)dt.Rows[0]["Portfolio_Status"];

            return entity;
        } // okuma i�lemi bitiyor

        internal List<PortfolioTblDAO> DataSource(string sql_, params SqlParameter[] paramss)
        {

            List<PortfolioTblDAO> list = new List<PortfolioTblDAO>();
            DataTable dt;
            if (paramss == null)
                dt = (DataTable)DbOperations.dtb(sql_);
            else
                dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);


            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            foreach (DataRow r in dt.Rows)
            {
                PortfolioTblDAO entity = new PortfolioTblDAO();

                if (columnNames.Contains("Portfolio_ID")) entity.Portfolio_ID = Convert.ToInt32(r["Portfolio_ID"].ToString());
                if (columnNames.Contains("Portfolio_Categori")) entity.Portfolio_Categori = Convert.ToInt32(r["Portfolio_Categori"].ToString());
                if (columnNames.Contains("Portfolio_Title")) entity.Portfolio_Title = r["Portfolio_Title"].ToString();
                if (columnNames.Contains("Portfolio_Content")) entity.Portfolio_Content = r["Portfolio_Content"].ToString();
                if (columnNames.Contains("Portfolio_Date")) entity.Portfolio_Date = (DateTime?)r["Portfolio_Date"];
                if (columnNames.Contains("Portfolio_Client")) entity.Portfolio_Client = r["Portfolio_Client"].ToString();
                if (columnNames.Contains("Portfolio_URL"))
                    entity.Portfolio_URL = r["Portfolio_URL"].ToString();
                if (columnNames.Contains("Portfolio_Image"))
                    entity.Portfolio_Image = r["Portfolio_Image"].ToString();

                if (columnNames.Contains("Portfolio_Status"))
                    entity.Portfolio_Status = (bool?)r["Portfolio_Status"];


                list.Add(entity);
            }

            return list;
        }

     
    }

}

