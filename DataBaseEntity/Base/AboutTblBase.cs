using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEntity.Base
{
    [Serializable]
    public class AboutTblBase
    {

        private int? _About_ID = null;
        private string _About_Title = null;
        private string _About_Content = null;
        private string _About_Image = null;
        private string _About_URL = null;
        private string _About_Social = null;
        private Boolean? _About_Status = null;


        public int? About_ID
        {
            get { return _About_ID; }
            set { _About_ID = value; }
        }

        public string About_Title
        {
            get { return _About_Title; }
            set { _About_Title = value; }
        }
        public string About_Content
        {
            get { return _About_Content; }
            set { _About_Content = value; }
        }

        public string About_Image
        {
            get { return _About_Image; }
            set { _About_Image = value; }
        }
        public string About_URL
        {
            get { return _About_URL; }
            set { _About_URL = value; }
        }
        public string About_Social
        {
            get { return _About_Social; }
            set { _About_Social = value; }
        }


        public Boolean? About_Status
        {
            get { return _About_Status; }
            set { _About_Status = value; }
        }

    }
}
