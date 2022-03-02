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
    public class SkillsTblDAO : SkillsTblBase
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

            if (this.Skills_ID == null) this.Skills_ID = 0;
            if (this.Skills_ID == 0)
            {
                if (Skills_Title != null)
                {
                    fieldsName += "Skills_Title,";
                    fieldsValue += "@Skills_Title,";
                    paramsayi++;
                }




                if (Skills_Percent != null)
                {
                    fieldsName += "Skills_Percent,";
                    fieldsValue += "@Skills_Percent,";
                    paramsayi++;
                }
                if (Skills_Status != null)
                {
                    fieldsName += "Skills_Status,";
                    fieldsValue += "@Skills_Status,";
                    paramsayi++;
                }


                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);
                fieldsValue = fieldsValue.Remove(fieldsValue.Length - 1, 1);


            }
            else
            {

                if (Skills_Title != null)
                {
                    fieldsName += "Skills_Title =@Skills_Title ,";
                    paramsayi++;
                }


                if (Skills_Percent != null)
                {
                    fieldsName += "Skills_Percent =@Skills_Percent ,";
                    paramsayi++;
                }
                if (Skills_Status != null)
                {
                    fieldsName += "Skills_Status=@Skills_Status,";
                    paramsayi++;
                }

                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);



            }

            sqlparam = new SqlParameter[paramsayi];


            while (paramsayi > i)
            {

                if (Skills_Title != null)
                {
                    sqlparam[i] = new SqlParameter("@Skills_Title", Skills_Title);
                    i++;
                }

                if (Skills_Percent != null)
                {
                    sqlparam[i] = new SqlParameter("@Skills_Percent", Skills_Percent);
                    i++;
                }
                if (Skills_Status != null)
                {
                    sqlparam[i] = new SqlParameter("@Skills_Status", Skills_Status);
                    i++;
                }

            }

            if (this.Skills_ID == 0)
            {
                sqlcum = "Insert INTO [SkillsTbl](" + fieldsName + ")Values(" + fieldsValue + ")";

                DbOperations.ParameterOperation(sqlcum, sqlparam);
                this.Skills_ID = Convert.ToInt32(DbOperations.dtb("select max(Id) from [SkillsTbl]").Rows[0][0]);
                return "1";
            }
            else
            {
                sqlcum = "UPDATE [SkillsTbl] SET " + fieldsName + " where Id =" + this.Skills_ID;
                DbOperations.ParameterOperation(sqlcum, sqlparam);
                return "2";
            }


        }

        internal string Delete(string _sql, params SqlParameter[] paramss)
        {
            DbOperations.ParameterOperation(_sql, paramss);
            return "3";
        }

        internal SkillsTblDAO Select(string sql_, params SqlParameter[] paramss)
        {

            SkillsTblDAO entity = new SkillsTblDAO();
            DataTable dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();

            if (columnNames.Contains("Skills_ID")) entity.Skills_ID = Convert.ToInt32(dt.Rows[0]["Skills_ID"].ToString());
            if (columnNames.Contains("Skills_Title")) entity.Skills_Title = dt.Rows[0]["Skills_Title"].ToString();

            if (columnNames.Contains("Skills_Content")) entity.Skills_Percent = dt.Rows[0]["Skills_Percent"].ToString();
            if (columnNames.Contains("Skills_Status")) entity.Skills_Status = (bool?)dt.Rows[0]["Skills_Status"];

            return entity;
        } // okuma i�lemi bitiyor

        internal List<SkillsTblDAO> DataSource(string sql_, params SqlParameter[] paramss)
        {

            List<SkillsTblDAO> list = new List<SkillsTblDAO>();
            DataTable dt;
            if (paramss == null)
                dt = (DataTable)DbOperations.dtb(sql_);
            else
                dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);


            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            foreach (DataRow r in dt.Rows)
            {
                SkillsTblDAO entity = new SkillsTblDAO();

                if (columnNames.Contains("Skills_ID")) entity.Skills_ID = Convert.ToInt32(r["Skills_ID"].ToString());
                if (columnNames.Contains("Skills_Title")) entity.Skills_Title = r["Skills_Title"].ToString();

                if (columnNames.Contains("Skills_Percent")) entity.Skills_Percent = r["Skills_Percent"].ToString();
                if (columnNames.Contains("Skills_Status")) entity.Skills_Status = (bool?)r["Skills_Status"];

                list.Add(entity);
            }

            return list;
        }

    }
}
