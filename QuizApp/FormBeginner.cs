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
    public partial class FormBeginner : Form
    {
        int n_Question=0,index_now;
        ReturnClass returnClass = new ReturnClass();
        Random random= new Random();
        List<int> q_id= new List<int>();
        List<string> q_option = new List<string>();
        List<int> q_Corection = new List<int>();
        int n_option = 4;
        public FormBeginner()
        {

            InitializeComponent();
        }
        
        private void InitQuestion()
        {
            q_id = RandomNumber(n_Question);
            for (int index = 0; index < n_Question; ++index)
                q_option.Add("");
            index_now = 0;
        }
        private void FormBeginner_Load(object sender, EventArgs e)
        {
            if(FormStudents.isTimes==true)
            {
                label2.Visible = true;
                lblTimes.Visible = true;
                timer1.Start();
            }
            n_Question = FormStudents.numQuestion;
            InitQuestion();
            RandomQuestion(q_id[index_now]);
            UpdateIndex();
            ReDrawLabel();
        }
        public void ReDrawLabel()
        {
            ptcOpA.Visible = false;
            ptcOpB.Visible = false;
            ptcOpC.Visible = false;
            ptcOpD.Visible = false;
            lblOpA.BackColor = System.Drawing.Color.Transparent;
            lblOpB.BackColor = System.Drawing.Color.Transparent;
            lblOpC.BackColor = System.Drawing.Color.Transparent;
            lblOpD.BackColor = System.Drawing.Color.Transparent;
        }
        public List<int> RandomNumber(int n_max_Num)
        {
            int n_Num = n_max_Num;
            List<int> Number = new List<int>();
            List<int> Result = new List<int>();
            for (int index = 1; index <= n_Num; ++index)
                Number.Add(index);
            for (int index = 0; index < n_Num; ++index)
            {
                int value = random.Next(n_max_Num);
                Result.Add(Number[value]);
                Number.RemoveAt(value);
                --n_max_Num;
            }
            return Result;
        }
        private void RandomQuestion(int i)
        {
            string msg = "select top 1 q_title,q_opa,q_opb,q_opc,q_opd " +
                         "from questions " +
                         "where q_id in (select top " + i+" q_id " +
                         "from questions inner join exams on exams.ex_id = questions.q_fk_ex " +
                         "where exam_name='"+FormStudents.examName+"' " +
                         "order by q_id asc) " +
                         "order by q_id desc";
            SqlDataReader sqlDataReader = returnClass.readerReturn(msg);
            List<int> Options = RandomNumber(n_option);
            if (sqlDataReader.Read())
            {
                lblQuestion.Text = sqlDataReader.GetValue(0).ToString();
                lblOpA.Text = sqlDataReader.GetValue(Options[0]).ToString();
                lblOpB.Text = sqlDataReader.GetValue(Options[1]).ToString();
                lblOpC.Text = sqlDataReader.GetValue(Options[2]).ToString();
                lblOpD.Text = sqlDataReader.GetValue(Options[3]).ToString();
            }
            sqlDataReader.Close();
        }
        private void lblOp_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        }

        private void lblOp_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.White;
        }

        public void Correct()
        {
            string msgBox="";
            float numCorrect = 0;
            for(int i=0;i<n_Question;++i)
            {
                string msg = "select top 1 q_opcorrect " +
                         "from questions " +
                         "where q_id in (select top " + q_id[i] + " q_id " +
                         "from questions inner join exams on exams.ex_id = questions.q_fk_ex " +
                         "where exam_name='" + FormStudents.examName + "' " +
                         "order by q_id asc) " +
                         "order by q_id desc";
                if (q_option[i].Equals(returnClass.scalarReturn(msg)))
                {
                    numCorrect+=1;
                    msgBox += (i+1) + ": true\n";
                }else msgBox += (i+1) + ": false\n";
            }
            msgBox += numCorrect + " Result True \n" + (10f / n_Question) * numCorrect + " Score";
            MessageBox.Show(msgBox);
        }
        public void DrawOption(PictureBox pictureBox,Label label)
        {
            pictureBox.Visible = true;
            label.BackColor = Color.FromArgb(61, 121, 64);
        }
        public void assignOption(Label lbl)
        {
            if (lbl.Name == "lblOpA") DrawOption(ptcOpA,lbl);
            if (lbl.Name == "lblOpB") DrawOption(ptcOpB, lbl);
            if (lbl.Name == "lblOpC") DrawOption(ptcOpC, lbl);
            if (lbl.Name == "lblOpD") DrawOption(ptcOpD, lbl);
        }
        private void lblOp_Click(object sender, EventArgs e)
        {
            ReDrawLabel();
            Label label = sender as Label;
            q_option[index_now] = label.Text;
            assignOption(label);
        }

        public void UpdateIndex()
        {
            lblIndex.Text = (index_now + 1) + "/" + n_Question;
        }
        //Click BackButton
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (index_now >0)
            {
                index_now -= 1;
                UpdateIndex();
                RandomQuestion(q_id[index_now]);
                RefreshSelect();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Correct();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<int> time = FormStudents.time;
            if (--time[1] == 0)
                if (time[0] == 0)
                {
                    timer1.Stop();
                    Correct();
                }    
                else
                {
                    --time[0];
                    time[1] = 60;
                }
            lblTimes.Text = time[0] + " : " + time[1];
        }

        public void RefreshSelect()
        {
            if (lblOpA.Text == q_option[index_now]) lblOp_Click(lblOpA, null);
            else if(lblOpB.Text == q_option[index_now]) lblOp_Click(lblOpB, null);
            else if (lblOpC.Text == q_option[index_now]) lblOp_Click(lblOpC, null);
            else if (lblOpD.Text == q_option[index_now]) lblOp_Click(lblOpD, null);
            else ReDrawLabel();
        }
        //Click NextButton
        private void btnNext_Click(object sender, EventArgs e)
        {
                if(index_now<n_Question-1)
                {
                        index_now += 1;
                        UpdateIndex();
                        RandomQuestion(q_id[index_now]);
                        RefreshSelect();
            }
        }
    }
}
//System.Drawing.Color.Transparent;
