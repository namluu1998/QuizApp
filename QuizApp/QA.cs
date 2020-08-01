using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    class QA
    {
        private static QA qa;

        private int numQues;
        private int exId;
        private int timePer;
        private int currentIndex = -1;
        PanelOptionStartForm panelDynamic;
        Questions qs { get; set; }
        List<string> IdQuestions;
        Random random = new Random();

        public List<List<int>> optionMix = new List<List<int>>();
        public List<List<bool>> check = new List<List<bool>>();


        private QA() { }
        public bool setQuestions(int numQues,int exId,int timePer)
        {
            string query = string.Format("select count(q_id) from questions where q_fk_ex ={0}", exId);
            string IdQuestions = ReturnClass.scalarReturn(query);
            if (string.IsNullOrEmpty(IdQuestions) || int.Parse(IdQuestions)<numQues) { MessBox.Warning("Num Question or Name Exams invalid "); return false; }
            this.numQues = numQues;
            this.exId = exId;
            this.timePer = timePer;
            optionMix.Clear();
            check.Clear();
            RandomNumberQs();
            InitRandomChoice();
            currentIndex = -1;
            return true;
        }
        public List<Questions> getQuestions()
        {
            List<Questions> questions = new List<Questions>();
            for (int i=0;i<IdQuestions.Count;++i)
                questions.Add(Questions.GetQuestions(IdQuestions[i]));
            return questions;

        }
        public void setPanel(Panel panel,ZoomImg zoomImg)
        {
            panelDynamic = new PanelOptionStartForm(panel,zoomImg);
        }
        private void setQuestion()
        {
            this.qs = Questions.GetQuestions(IdQuestions[currentIndex]);
            if(currentIndex>=0)DisplayQsOp();
        }
        public Questions GetQuestions()
        {
            return this.qs;
        }
        public Questions getQuestion(int index)
        {
            return Questions.GetQuestions(IdQuestions[index]);
        }
        public long getTime()
        {
            return timePer * numQues;
        }
        private string getIndexAndQs()
        {
            return (currentIndex + 1) + "\\" + numQues;
        }
        public string nextStep()
        {
            if (currentIndex == IdQuestions.Count - 1) return getIndexAndQs();
            ++currentIndex;
            setQuestion();
            return getIndexAndQs();

        }
        public string backStep()
        {
            if (currentIndex <= 0) return getIndexAndQs();
            --currentIndex;
            setQuestion();
            return getIndexAndQs();
        }
        public void DisplayQsOp()
        {
            panelDynamic.DisplayOption(IdQuestions[currentIndex], optionMix[currentIndex], check[currentIndex],qs.getOption());
        }
        public void RandomNumberQs()
        {
            List<int> idQuestions;
            string query = string.Format("select q_id from questions");
            using(SqlDataReader reader = ReturnClass.readerReturn(query))
            {
                idQuestions = (from IDataRecord r in reader select (int)r["q_id"]).ToList<int>();
            }
            List<string> IdQuestions = new List<string>();
            for (int index = 0; index < this.numQues; ++index)
            {
                int value = random.Next(idQuestions.Count);

                IdQuestions.Add(idQuestions[value].ToString());
                idQuestions.RemoveAt(value);
            }
            //MessageBox.Show(string.Join("\n", IdQuestions));
            this.IdQuestions = IdQuestions;
        }
        private void InitRandomChoice()
        {
            ////Random Choice 
            for (int i = 0; i < IdQuestions.Count; ++i)
            {
                string query = string.Format("select count(id) from Options where id_Qus ={0}", IdQuestions[i]);
                optionMix.Add(new List<int>());
                check.Add(new List<bool>());
                FillOption(int.Parse(ReturnClass.scalarReturn(query)), optionMix[i], check[i]);
            }
        }
        private void FillOption(int n_max_Num, List<int> optionMix, List<bool> check)
        {
            int n_Num = n_max_Num;
            List<int> Number = new List<int>();
            for (int index = 0; index < n_Num; ++index)
                Number.Add(index);
            for (int index = 0; index < n_Num; ++index)
            {
                int value = random.Next(n_max_Num);
                check.Add(false);
                optionMix.Add(Number[value]);
                Number.RemoveAt(value);
                --n_max_Num;
            }
        }
        public static QA getInstance()
        {
            if (qa == null) qa = new QA();
            return qa;
        }
        public static void Clear()
        {
            qa = null;
        }
    }
}
