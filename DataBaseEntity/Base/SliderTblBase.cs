using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEntity.Base
{
    [Serializable]
    public class SliderTblBase
    {


        private int? _Slider_ID = null;
        private string _Slider_Title = null;
        private string _Slider_Content = null;
        private string _Slider_Image = null;
        private Boolean? _Slider_Status = null;


        public int? Slider_ID
        {
            get { return _Slider_ID; }
            set { _Slider_ID = value; }
        }

        public string Slider_Title
        {
            get { return _Slider_Title; }
            set { _Slider_Title = value; }
        }
        public string Slider_Content
        {
            get { return _Slider_Content; }
            set { _Slider_Content = value; }
        }
     
        public string Slider_Image
        {
            get { return _Slider_Image; }
            set { _Slider_Image = value; }
        }

        public Boolean? Slider_Status
        {
            get { return _Slider_Status; }
            set { _Slider_Status = value; }
        }


    }
}
