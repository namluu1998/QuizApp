using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    class Options
    {
        public string id { get; set; }
        public string Contents { get; set; }
        public string id_Qus { get; set; }
        public string isImages { get; set; }
        public string isCorrect { get; set; }
        private Options() { }
        public Options(string Contents, string isImages, string isCorrect)
        {
            this.Contents = Contents;
            this.id_Qus = id_Qus;
            this.isImages = isImages;
            this.isCorrect = isCorrect;

        }
        public Options(string id, string Contents, string isImages, string isCorrect) : this(Contents, isImages, isCorrect)
        {
            this.id = id;
        }
        public void insertOption(string idQues)
        {
            string queryInsertOption = string.Format("insert into Options values(N'{0}',{1},{2},{3})", 
                RgEx.isNullOrEmpty(Contents), RgEx.isNullOrEmpty(idQues),RgEx.isNullOrEmpty(isImages),RgEx.isNullOrEmpty(isCorrect));
            ReturnClass.ExcuteNonQuery(queryInsertOption);
        }
        public void DeleteOption()
        {
            string query = string.Format("delete Options where id ={0}", id);
            ReturnClass.ExcuteNonQuery(query);
        }
        public void updateOption()
        {
            if (string.IsNullOrEmpty(this.id)) { insertOption(id_Qus); return; }
            if (RgEx.isEmpty(Contents)) { DeleteOption();return; }
            string queryInsertOption = string.Format("update Options set Contents = N'{0}', isImages = {1},isCorrect = {2} where id_Qus = {3} and id ={4}",
                RgEx.isNullOrEmpty(Contents), RgEx.isNullOrEmpty(isImages), RgEx.isNullOrEmpty(isCorrect), 
                RgEx.isNullOrEmpty(id_Qus),RgEx.isNullOrEmpty(id));
            ReturnClass.ExcuteNonQuery(queryInsertOption);
        }
        public static void DeleteWithQsCode(int q_id)
        {
            string query = string.Format("delete Options where id_Qus ={0}", q_id);
            ReturnClass.ExcuteNonQuery(query);
        }
    }
}
