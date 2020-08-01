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
        List<int> examsCode = new List<int>();
        public static int numQuestion;
        public static string examName;
        public static bool isTimes = false;
        //public static long time;
        ReturnClass ReturnClass = new ReturnClass();
        public FormStudents()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void FormChooseExams_Load(object sender, EventArgs e)
        {
            string query = "select * from exams ";
            //Load eclipse Border in Form
            this.Eclipse.ApplyElipse(this, 20);
            this.Eclipse.ApplyElipse(bunifuGradientPanel1, 15);
            //Load Component in Combo box Name Exams
            using(SqlDataReader reader = ReturnClass.readerReturn(query))
            {
                List<string> exName = new List<string>();
                while (reader.Read())
                {
                    examsCode.Add(reader.GetInt32(0));
                    exName.Add(reader.GetString(1));
                }
                cbxNameExams.Items = exName.ToArray();
            }
            this.KeyPreview = true;

            /* SetCombo box Selected */
            cbxNameExams.selectedIndex = 0;
            cbxSelectNumExams.SelectedIndex = 0;
            cbxTimes.SelectedIndex = 0;
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (cbxNameExams.selectedIndex == -1) { MessBox.Warning("Not selected Name Exams !! Please Select ");return; };
            if (stringToInt(cbxSelectNumExams.Text) <= 0) { MessBox.Warning("Invalid Number Question !! ");return; }
            if (stringToInt(cbxTimes.Text) <= 0 && !cbxTimes.Text.Equals("None")) { MessBox.Warning("Invalid Times/Number Question !! "); return; }
            if(!QA.getInstance().setQuestions(stringToInt(cbxSelectNumExams.Text), examsCode[cbxNameExams.selectedIndex], stringToInt(cbxTimes.Text)))
                return;

            //Hide and show form beginner
            this.Hide();
            using(var form = new StartForm())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void FormStudents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.F4) btnExit_Click(null, null);
        }
    }
}
