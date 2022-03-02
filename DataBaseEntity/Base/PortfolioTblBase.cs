using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEntity.Base
{
    [Serializable]

    public class PortfolioTblBase
    {

        private int? _Portfolio_ID = null;
        private string _Portfolio_Title = null;
        private string _Portfolio_Content = null;
        private DateTime? _Portfolio_Date = null;
        private string _Portfolio_Client = null;
        private string _Portfolio_URL = null;
        private string _Portfolio_Image = null;
        private int? _Portfolio_Categori = null;
        private Boolean? _Portfolio_Status = null;


        public int? Portfolio_ID
        {
            get { return _Portfolio_ID; }
            set { _Portfolio_ID = value; }
        }

        public string Portfolio_Title
        {
            get { return _Portfolio_Title; }
            set { _Portfolio_Title = value; }
        }
        public string Portfolio_Content
        {
            get { return _Portfolio_Content; }
            set { _Portfolio_Content = value; }
        }
        public DateTime? Portfolio_Date
        {
            get { return _Portfolio_Date; }
            set { _Portfolio_Date = value; }
        }
        public string Portfolio_Client
        {
            get { return _Portfolio_Client; }
            set { _Portfolio_Client = value; }
        }
        public string Portfolio_URL
        {
            get { return _Portfolio_URL; }
            set { _Portfolio_URL = value; }
        }
        public string Portfolio_Image
        {
            get { return _Portfolio_Image; }
            set { _Portfolio_Image = value; }
        }
        public int? Portfolio_Categori
        {
            get { return _Portfolio_Categori; }
            set { _Portfolio_Categori = value; }
        }

        public Boolean? Portfolio_Status
        {
            get { return _Portfolio_Status; }
            set { _Portfolio_Status = value; }
        }



    }
}
