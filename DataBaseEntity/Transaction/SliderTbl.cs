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
    public class SliderTbl : SliderTblDAO
    {


        public string Save(SliderTblDAO tbl)
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

        public IEnumerable<object> SliderTblDAO()
        {
            throw new NotImplementedException();
        }

        public string Delete(int Slider_ID)
        {
            try
            {
                return new SliderTblDAO().Delete("Delete From [SliderTbl] where Slider_ID=@Slider_ID", new SqlParameter("@Slider_ID", Slider_ID));
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public SliderTblDAO Select(int Slider_ID)
        {
            return new SliderTblDAO().Select("select * from [SliderTbl] where Slider_ID=@Slider_ID", new SqlParameter("@Slider_ID", Slider_ID));
        }
        public SliderTblDAO SelectExist(string tc)
        {
            return new SliderTblDAO().Select("select * from [SliderTbl] where tc=@Id", new SqlParameter("@Id", tc));
        }

        public List<SliderTblDAO> DataSource()
        {
            return new SliderTblDAO().DataSource("select * from [SliderTbl]");
        }

    }
}
