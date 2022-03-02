using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEntity.Base
{
    [Serializable]
    public class ContactTblBase
    {
        private int? _Contact_ID = null;
        private string _Contact_Mail = null;
       private string _Contact_Phone = null;
        private string _Contact_Address = null;




        public int? Contact_ID
        {
            get { return _Contact_ID; }
            set { _Contact_ID = value; }
        }

        public string Contact_Mail
        {
            get { return _Contact_Mail; }
            set { _Contact_Mail = value; }
        }

        public string Contact_Phone
        {
            get { return _Contact_Phone; }
            set { _Contact_Phone = value; }
        }
        public string Contact_Address
        {
            get { return _Contact_Address; }
            set { _Contact_Address = value; }
        }


    }
}
