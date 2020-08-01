using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Exams
    {
        string ex_id { get; set; }
        string exam_name { get; set; }

        private Exams() { }
        public Exams(string exam_name)
        {
            this.exam_name = exam_name;
        }
        public Exams(string ex_id,string exam_name) : this(exam_name)
        {
            this.ex_id = ex_id;
        }
        public void Insert()
        {
            string query = string.Format("insert exams values('{0}')", exam_name);
            ReturnClass.ExcuteNonQuery(query, ReturnClass.Status.insert);
        }
        public void Update()
        {
            if (RgEx.isEmpty(exam_name)) { MessBox.MessError("Empty Exams");return; }
            string query = string.Format("update exams set exam_name = '{0}' where ex_id = {1}",exam_name,ex_id);
            ReturnClass.ExcuteNonQuery(query, ReturnClass.Status.update);
        }
        public static void Delete(int exId)
        {
            string query = string.Format("select count(q_id) from questions where q_fk_ex ={0}", exId);

            if (!MessBox.MessWarning(" Confirm deleted " + ReturnClass.scalarReturn(query) + " questions"))
                return;
            //Process Delete Exams
            query = string.Format("select q_id from questions where q_fk_ex ={0}", exId);
            using (SqlDataReader reader = ReturnClass.readerReturn(query))
            {
                while(reader.Read()) 
                    Questions.DeleteQuestion(reader.GetInt32(0));
            }
        }
    }
}
