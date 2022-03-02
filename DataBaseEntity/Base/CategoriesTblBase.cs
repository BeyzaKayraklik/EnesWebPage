using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEntity.Base
{
    [Serializable]
   public class CategoriesTblBase
    {

        private int? _Categories_ID = null;
        private string _Categories_Title = null;
        private string _Categories_Image = null;
        private string _Categories_Content = null;
        private Boolean? _Categories_Status = null;




        public int? Categories_ID
        {
            get { return _Categories_ID; }
            set { _Categories_ID = value; }
        }

        public string Categories_Title
        {
            get { return _Categories_Title; }
            set { _Categories_Title = value; }
        }
        public string Categories_Image
        {
            get { return _Categories_Image; }
            set { _Categories_Image = value; }
        }

        public string Categories_Content
        {
            get { return _Categories_Content; }
            set { _Categories_Content = value; }
        }
        public Boolean? Categories_Status
        {
            get { return _Categories_Status; }
            set { _Categories_Status = value; }
        }


    }
}
