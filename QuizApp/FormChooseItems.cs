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
    public partial class FormChooseItems : Form
    {
        public FormChooseItems()
        {
            InitializeComponent();
        }

        private void ptcAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            ptcAdmin.BackgroundImage = Properties.Resources.AdminIconClick;
            lblAdmin.ForeColor = Color.White;
        }

        private void ptcAdmin_MouseLeave(object sender, EventArgs e)
        {
            ptcAdmin.BackgroundImage = Properties.Resources.Admin_icon;
            lblAdmin.ForeColor = System.Drawing.SystemColors.ScrollBar;
        }

        private void ptcStudents_MouseMove(object sender, MouseEventArgs e)
        {
            ptcStudents.BackgroundImage = Properties.Resources.UserGroupIconClick;
            lblStudents.ForeColor = Color.White;
        }

        private void ptcStudents_MouseLeave(object sender, EventArgs e)
        {
            ptcStudents.BackgroundImage = Properties.Resources.User_Group_icon;
            lblStudents.ForeColor = System.Drawing.SystemColors.ScrollBar;
        }

        private void ptcExit_MouseMove(object sender, MouseEventArgs e)
        {
            ptcExit.BackgroundImage = Properties.Resources.cross;
        }

        private void ptcExit_MouseLeave(object sender, EventArgs e)
        {
            ptcExit.BackgroundImage = Properties.Resources.Exit;
        }

        private void ptcExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptcAdmin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
