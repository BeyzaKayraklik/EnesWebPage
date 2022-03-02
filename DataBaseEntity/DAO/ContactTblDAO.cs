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
    public class ContactTblDAO : ContactTblBase
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

            if (this.Contact_ID == null) this.Contact_ID = 0;
            if (this.Contact_ID == 0)
            {
                if (Contact_Mail != null)
                {
                    fieldsName += "Contact_Mail,";
                    fieldsValue += "@Contact_Mail,";
                    paramsayi++;
                }




                if (Contact_Phone != null)
                {
                    fieldsName += "Contact_Phone,";
                    fieldsValue += "@Contact_Phone,";
                    paramsayi++;
                }
                if (Contact_Address != null)
                {
                    fieldsName += "Contact_Address,";
                    fieldsValue += "@Contact_Address,";
                    paramsayi++;
                }


                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);
                fieldsValue = fieldsValue.Remove(fieldsValue.Length - 1, 1);


            }
            else
            {

                if (Contact_Mail != null)
                {
                    fieldsName += "Contact_Mail =@Contact_Mail ,";
                    paramsayi++;
                }


                if (Contact_Phone != null)
                {
                    fieldsName += "Contact_Phone =@Contact_Phone ,";
                    paramsayi++;
                }
                if (Contact_Address != null)
                {
                    fieldsName += "Contact_Address=@Contact_Address,";
                    paramsayi++;
                }

                fieldsName = fieldsName.Remove(fieldsName.Length - 1, 1);



            }

            sqlparam = new SqlParameter[paramsayi];


            while (paramsayi > i)
            {

                if (Contact_Mail != null)
                {
                    sqlparam[i] = new SqlParameter("@Contact_Mail", Contact_Mail);
                    i++;
                }

                if (Contact_Phone != null)
                {
                    sqlparam[i] = new SqlParameter("@Contact_Phone", Contact_Phone);
                    i++;
                }
                if (Contact_Address != null)
                {
                    sqlparam[i] = new SqlParameter("@Contact_Address", Contact_Address);
                    i++;
                }

            }

            if (this.Contact_ID == 0)
            {
                sqlcum = "Insert INTO [ContactTbl](" + fieldsName + ")Values(" + fieldsValue + ")";

                DbOperations.ParameterOperation(sqlcum, sqlparam);
                this.Contact_ID = Convert.ToInt32(DbOperations.dtb("select max(Id) from [ContactTbl]").Rows[0][0]);
                return "1";
            }
            else
            {
                sqlcum = "UPDATE [ContactTbl] SET " + fieldsName + " where Id =" + this.Contact_ID;
                DbOperations.ParameterOperation(sqlcum, sqlparam);
                return "2";
            }


        }

        internal string Delete(string _sql, params SqlParameter[] paramss)
        {
            DbOperations.ParameterOperation(_sql, paramss);
            return "3";
        }

        internal ContactTblDAO Select(string sql_, params SqlParameter[] paramss)
        {

            ContactTblDAO entity = new ContactTblDAO();
            DataTable dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();

            if (columnNames.Contains("Contact_ID")) entity.Contact_ID = Convert.ToInt32(dt.Rows[0]["Contact_ID"].ToString());
            if (columnNames.Contains("Contact_Mail")) entity.Contact_Mail = dt.Rows[0]["Contact_Mail"].ToString();

            if (columnNames.Contains("Contact_Phone")) entity.Contact_Phone = dt.Rows[0]["Contact_Phone"].ToString();
            if (columnNames.Contains("Contact_Address")) entity.Contact_Address = dt.Rows[0]["Contact_Address"].ToString();

            return entity;
        } // okuma i�lemi bitiyor

        internal List<ContactTblDAO> DataSource(string sql_, params SqlParameter[] paramss)
        {

            List<ContactTblDAO> list = new List<ContactTblDAO>();
            DataTable dt;
            if (paramss == null)
                dt = (DataTable)DbOperations.dtb(sql_);
            else
                dt = (DataTable)DbOperations.ParameterOperation(sql_, paramss);


            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            foreach (DataRow r in dt.Rows)
            {
                ContactTblDAO entity = new ContactTblDAO();

                if (columnNames.Contains("Contact_ID")) entity.Contact_ID = Convert.ToInt32(r["Contact_ID"].ToString());
                if (columnNames.Contains("Contact_Mail")) entity.Contact_Mail = r["Contact_Mail"].ToString();

                if (columnNames.Contains("Contact_Phone")) entity.Contact_Phone = r["Contact_Phone"].ToString();
                if (columnNames.Contains("Contact_Address")) entity.Contact_Address = r["Contact_Address"].ToString();

                list.Add(entity);
            }

            return list;
        }


    }
}
