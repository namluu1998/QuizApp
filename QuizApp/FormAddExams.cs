using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class FormAddExams : Form
    {
        public FormAddExams()
        {
            InitializeComponent(); 
            this.examsTableAdapter.Fill(this.quizappDataSet.exams);
        }

        private void FormAddExamples_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizappDataSet.exams' table. You can move, or remove it, as needed.
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Questions question = new Questions();
            question.q_title = rtxtQuestion.Text;
            question.q_opa = rtxtOptionA.Text;
            question.q_opb = rtxtOptionB.Text;
            question.q_opc = rtxtOptionC.Text;
            question.q_opd = rtxtOptionD.Text;
            question.q_opcorrect = rtxtCorrect.Text;
            question.q_addeddate = System.DateTime.Now.ToString();
            question.q_fk_ad = //FormLogin.fk_ad.ToString();
            question.q_fk_ex = (cbxTypeQuestion.SelectedIndex+1).ToString();

            InsertClass insertClass = new InsertClass();
            string msg = insertClass.insertQuestion(question);
            MessageBox.Show(msg);
            rtxtQuestion.Clear();
            rtxtOptionA.Clear();
            rtxtOptionB.Clear();
            rtxtOptionC.Clear();
            rtxtOptionD.Clear();
            rtxtCorrect.Clear();
        }
    }
}
