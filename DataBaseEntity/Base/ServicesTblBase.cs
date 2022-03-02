using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEntity.Base
{
    [Serializable]
    public  class ServicesTblBase
    {

        private int? _Services_ID = null;
        private string _Services_Title = null;

        private string _Services_Content = null;
        private Boolean? _Services_Status = null;




        public int? Services_ID
        {
            get { return _Services_ID; }
            set { _Services_ID = value; }
        }

        public string Services_Title
        {
            get { return _Services_Title; }
            set { _Services_Title = value; }
        }
    
        public string Services_Content
        {
            get { return _Services_Content; }
            set { _Services_Content = value; }
        }
        public Boolean? Services_Status
        {
            get { return _Services_Status; }
            set { _Services_Status = value; }
        }

    }
}
