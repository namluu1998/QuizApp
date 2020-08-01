using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    class Questions
    {
        public string q_id { get; set; }
        public string q_title { get; set; }
        public string q_addeddate { get; set; }
        public string q_fk_ex { get; set; }
        public string ad_add { get; set; }
        public string isImage { get; set; }

        public string explain { get; set; }
        public List<Options> options;

        public Questions() { }
        public Questions(string q_title,string q_addeddate, string q_fk_ex, string ad_add,string isImage,string explain)
        {
            this.q_title = q_title;
            this.q_addeddate = q_addeddate;
            this.q_fk_ex = q_fk_ex;
            this.ad_add = ad_add;
            this.isImage = isImage;
            this.explain = explain;
        }
        public Questions(string q_id,string q_title, string q_addeddate, string q_fk_ex, string ad_add, string isImage,string explain) 
            : this(q_title,q_addeddate,q_fk_ex,ad_add,isImage,explain)
        {
            this.q_id = q_id;
        }
        public void setOption(List<Options> options)
        {
            this.options = options;
        }
        public List<Options> getOption()
        {
            string query = string.Format("select * from Options where id_Qus ={0}",q_id);
            List<Options> options = new List<Options>();
            using(SqlDataReader reader = ReturnClass.readerReturn(query))
            {
                while(reader.Read())
                {
                    string id_Op = reader.GetInt32(0).ToString();
                    string Contents = reader.GetString(1);
                    string id_ques = reader.GetInt32(2).ToString();
                    string isImage = DataReader.getStringBitDb(reader.GetBoolean(3));
                    string isCorrect = DataReader.getStringBitDb(reader.GetBoolean(4));
                    Options op = new Options(id_Op, Contents, isImage, isCorrect);
                    op.id_Qus = id_ques;
                    options.Add(op);
                }
            }
            setOption(options);
            return options;
        }
        public static Questions GetQuestions(string idQues)
        {
            Questions question = new Questions();
            try
            {
                string query = string.Format("select q_title,isImage from questions where q_id = {0}", idQues);
                using (SqlDataReader reader = ReturnClass.readerReturn(query))
                    if (reader.Read())
                    {
                        question.q_id = idQues;
                        question.q_title =  DataReader.GetDataReader(reader, 0) as string;
                        question.isImage = DataReader.getStringBitDb((bool)DataReader.GetDataReader(reader, 1));
                    }
                //question.getOption();
                return question;
            }catch
            {
                return null;
            }
        }
        public void InsertQuestion()
        {
            string query = string.Format("insert into questions values (N'{0}','{1}',{2},'{3}',{4},'{5}')", 
                RgEx.isNullOrEmpty(q_title), RgEx.isNullOrEmpty(q_addeddate), RgEx.isNullOrEmpty(q_fk_ex),
                RgEx.isNullOrEmpty(ad_add), RgEx.isNullOrEmpty(isImage),this.explain);
            ReturnClass.ExcuteNonQuery(query,ReturnClass.Status.insert);

            query = string.Format("select top 1 q_id from questions order by q_id desc");
            string id_Ques = ReturnClass.scalarReturn(query);
            options.ForEach
                (
                    x => x.insertOption(id_Ques)
                );
        }
        public void UpdateQuestion()
        {
            if (RgEx.isEmpty(q_title)) { MessBox.MessWarning("Chưa nhập câu hỏi !!");return; }
            string query = string.Format("update questions set q_title = N'{0}',isImage = {1},explain ='{2}' where q_id = {3}",
                q_title, isImage,explain, q_id);
            ReturnClass.ExcuteNonQuery(query, ReturnClass.Status.update);
            //for (int i = 0; i < options.Count; ++i) 
            foreach(var dt in options)
            {
                dt.id_Qus = dt.id_Qus ?? this.q_id;
                dt.updateOption();
            }

        }
        public static void DeleteQuestion(int quesId)
        {
            Options.DeleteWithQsCode(quesId);
            string str = string.Format("delete questions where q_id = {0}", quesId);
        }
    }
}
