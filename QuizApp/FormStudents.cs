using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class FormStudents : Form
    {
        public static int numQuestion;
        public static string examName;
        public static bool isTimes = false;
        public static List<int> time = new List<int>() { 0, 0 };
        ReturnClass ReturnClass = new ReturnClass();
        public FormStudents()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChooseExams_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizappDataSet.exams' table. You can move, or remove it, as needed.
            this.examsTableAdapter.Fill(this.quizappDataSet.exams);
            //cbxSelectExams.DataBindings

        }
        public int stringToInt(string str)
        {
            try
            {
                return int.Parse(str);
            }catch(Exception)
            {
                return 0;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            numQuestion = stringToInt(cbxSelectNumExams.Text);
            string sqlCommand = "select count(q_id)" +
                " from questions inner join exams on exams.ex_id = questions.q_fk_ex" +
                " where exams.exam_name = '"+ cbxChooseExam.Text+"'";
            if (numQuestion==0)
            {
                MessageBox.Show("Invalid input Number question ");
                return;
            }
            else if (stringToInt(ReturnClass.scalarReturn(sqlCommand)) < numQuestion)
            {
                MessageBox.Show("The number of questions must be smaller "+ stringToInt(ReturnClass.scalarReturn(sqlCommand)));
                return;
            }
            else
            {

                //Hide Form
                this.Hide();
                //set isTime
                int seconds = stringToInt(cbxTimes.Text);
                if (seconds == 0)
                    isTimes = false;
                else
                {
                    seconds *= numQuestion;
                    time[0] = seconds / 60;
                    time[1] = seconds % 60;
                    isTimes = true;
                }
                examName = cbxChooseExam.Text;
                FormBeginner formBeginner = new FormBeginner();
                formBeginner.ShowDialog();
                this.Show();
            }
            //if()
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(ReturnClass.connstring);
            sqlConnection.Open();
            string msg = "select q_id,q_title " +
            "from questions inner join exams on exams.ex_id = questions.q_fk_ex " +
            "where exams.exam_name = 'java' and q_id = 2";
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand = new SqlCommand(msg,sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                MessageBox.Show(sqlDataReader.GetValue(0).ToString() + "\n" + sqlDataReader.GetValue(1).ToString());
            }


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
