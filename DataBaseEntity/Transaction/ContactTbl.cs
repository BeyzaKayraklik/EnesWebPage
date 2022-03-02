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
    public class ContactTbl : ContactTblDAO
    {

        public string Save(ContactTblDAO tbl)
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

        public IEnumerable<object> ContactTblDAO()
        {
            throw new NotImplementedException();
        }

        public string Delete(int Contact_ID)
        {
            try
            {
                return new ContactTblDAO().Delete("Delete From [ContactTbl] where Contact_ID=@Contact_ID", new SqlParameter("@Contact_ID", Contact_ID));
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public ContactTblDAO Select(int Contact_ID)
        {
            return new ContactTblDAO().Select("select * from [ContactTbl] where Contact_ID=@Contact_ID", new SqlParameter("@Contact_ID", Contact_ID));
        }
        public ContactTblDAO SelectExist(string Contacts_Mail)
        {
            return new ContactTblDAO().Select("select * from [ContactTbl] where Contact_Mail=@Contact_ID", new SqlParameter("@Contact_ID", Contact_Mail));
        }

        public List<ContactTblDAO> DataSource()
        {
            return new ContactTblDAO().DataSource("select * from [ContactTbl]");
        }
    }
}
