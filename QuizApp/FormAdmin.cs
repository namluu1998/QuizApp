using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class FormAdmin : Form
    {
        private Panel currentChillPanel;
        FormAddExams formAddExams;
        FormDeleteQuestion formDeleteQuestion;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            this.examsTableAdapter.Fill(this.quizappDataSet.exams);
            // TODO: This line of code loads data into the 'quizappDataSet.exams' table. You can move, or remove it, as needed.
            this.examsTableAdapter.Fill(this.quizappDataSet.exams);
            this.bunifuElipse1.ApplyElipse(panel1, 40);
            this.bunifuElipse1.ApplyElipse(panel2, 20);
            panel14.AutoScroll = true;

            formAddExams = new FormAddExams();
            formAddExams.TopLevel = false;

            formDeleteQuestion = new FormDeleteQuestion();
            formDeleteQuestion.TopLevel = false;
            //this.bunifuElipse1.ApplyElipse(panel1, 40);
            //this.bunifuElipse1.ApplyElipse(rtxtQuestion, 20);
            //this.bunifuElipse1.ApplyElipse(rtxtCorrect, 20);
            //this.bunifuElipse1.ApplyElipse(rtxtOptionA, 20);
            //this.bunifuElipse1.ApplyElipse(rtxtOptionB, 20);
            //this.bunifuElipse1.ApplyElipse(rtxtOptionC, 20);
            //this.bunifuElipse1.ApplyElipse(rtxtOptionD, 20);
            //this.bunifuElipse1.ApplyElipse(cbxTypeQuestion, 20);

            //panelAddExams.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddExams_Click(object sender, EventArgs e)
        {
            OpenChillForm(formAddExams.panel1);
        }
        private void OpenChillForm(Panel chillPanel)
        {
            if(currentChillPanel!=null)
            {
                panel14.Controls.Remove(currentChillPanel);
            }

            //formLogin.TopMost = true;
            //formLogin.AutoScroll = true;
            //formLogin.FormBorderStyle = FormBorderStyle.None;
            //formLogin.Dock = DockStyle.Fill;
            //formLogin.AutoScroll = true;
            currentChillPanel = chillPanel;
            panel14.Controls.Add(chillPanel);
            
        }
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteExams_Click(object sender, EventArgs e)
        {
            OpenChillForm(formDeleteQuestion.panel1);
        }
    }
}
