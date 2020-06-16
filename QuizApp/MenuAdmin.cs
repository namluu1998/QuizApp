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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void ptcAddExamples_MouseLeave(object sender, EventArgs e)
        {
            ptcAddExamples.BackgroundImage = Properties.Resources.quiz;
            lblAddExamples.ForeColor = System.Drawing.SystemColors.ScrollBar;
        }

        private void ptcAddExamples_MouseMove(object sender, MouseEventArgs e)
        {
            ptcAddExamples.BackgroundImage = Properties.Resources.quizMove;
            lblAddExamples.ForeColor = Color.White;
        }

        private void ptcAddUser_MouseMove(object sender, MouseEventArgs e)
        {
            ptcAddUser.BackgroundImage = Properties.Resources.AddStudentsMove;
            lblAddUser.ForeColor = Color.White;
        }

        private void ptcAddUser_MouseLeave(object sender, EventArgs e)
        {
            ptcAddUser.BackgroundImage = Properties.Resources.AddStudents;
            lblAddUser.ForeColor = System.Drawing.SystemColors.ScrollBar;
        }

        private void ptcAddExamples_Click(object sender, EventArgs e)
        {
            FormAddExams formAddExamples = new FormAddExams();
            formAddExamples.Show();
        }
    }
}
