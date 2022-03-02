using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEntity.Base
{ 
    [Serializable]
    public class ProjectTblBase
    {

            private int? _Project_ID = null;
            private string _Project_Title = null;
            private string _Project_Content = null;
            private DateTime? _Project_Date = null;
            private string _Project_Client = null;
            private string _Project_URL = null;
            private string _Project_Image = null;
            private int? _Project_Categori = null;
            private Boolean? _Project_Status = null;


            public int? Project_ID
        {
                get { return _Project_ID; }
                set { _Project_ID = value; }
            }

            public string Project_Title
        {
                get { return _Project_Title; }
                set { _Project_Title = value; }
            }
            public string Project_Content
        {
                get { return _Project_Content; }
                set { _Project_Content = value; }
            }
            public DateTime? Project_Date
        {
                get { return _Project_Date; }
                set { _Project_Date = value; }
            }
            public string Project_Client
        {
                get { return _Project_Client; }
                set { _Project_Client = value; }
            }
            public string Project_URL
        {
                get { return _Project_URL; }
                set { _Project_URL = value; }
            }
            public string Project_Image
        {
                get { return _Project_Image; }
                set { _Project_Image = value; }
            }
            public int? Project_Categori
        {
                get { return _Project_Categori; }
                set { _Project_Categori = value; }
            }

            public Boolean? Project_Status
        {
                get { return _Project_Status; }
                set { _Project_Status = value; }
            }



        }
    }

