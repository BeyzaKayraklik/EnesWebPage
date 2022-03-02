using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEntity.Base
{
    [Serializable]
    public class SkillsTblBase
    {
        private int? _Skills_ID = null;
        private string _Skills_Title = null;

        private string _Skills_Percent = null;
        private Boolean? _Skills_Status = null;




        public int? Skills_ID
        {
            get { return _Skills_ID; }
            set { _Skills_ID = value; }
        }

        public string Skills_Title
        {
            get { return _Skills_Title; }
            set { _Skills_Title = value; }
        }

        public string Skills_Percent
        {
            get { return _Skills_Percent; }
            set { _Skills_Percent = value; }
        }
        public Boolean? Skills_Status
        {
            get { return _Skills_Status; }
            set { _Skills_Status = value; }
        }

    }
}
