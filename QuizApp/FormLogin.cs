using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuizApp
{
    public partial class FormLogin : Form
    {
        public static int fk_ad;

        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ptcExit_MouseLeave(object sender, EventArgs e)
        {
            ptcExit.BackgroundImage = Properties.Resources.Exit;
        }

        private void ptcExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptcExit_MouseHover(object sender, EventArgs e)
        {
            this.ptcExit.BackgroundImage = Properties.Resources.cross;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username") txtUsername.Text = "";
            ptcUsername.BackgroundImage = Properties.Resources.user2;
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") txtUsername.Text = "Username";
            ptcUsername.BackgroundImage = Properties.Resources.user1;
            txtUsername.ForeColor = Color.WhiteSmoke;
            panel1.ForeColor = Color.WhiteSmoke;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password") txtPassword.Clear();
            ptcPassword.BackgroundImage = Properties.Resources.unlock;
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") txtPassword.Text = "Password";
            ptcPassword.BackgroundImage = Properties.Resources.unlock1;
            txtPassword.ForeColor = Color.WhiteSmoke;
            panel2.ForeColor = Color.WhiteSmoke;
        }

        private void txtGmail_Enter(object sender, EventArgs e)
        {
            if (txtGmail.Text == "Username") txtGmail.Clear();
            ptcGmail.BackgroundImage = Properties.Resources.mail11;
            txtGmail.ForeColor = Color.FromArgb(78, 184, 206);
            panel3.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void txtGmail_Leave(object sender, EventArgs e)
        {

            if (txtGmail.Text == "") txtGmail.Text = "Username";
            ptcGmail.BackgroundImage = Properties.Resources.mail1;
            txtGmail.ForeColor = Color.WhiteSmoke;
            panel3.ForeColor = Color.WhiteSmoke;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                string userdb;
                ReturnClass returnClass = new ReturnClass();
                userdb = returnClass.scalarReturn("select count(ad_id) from admin_athu where ad_user='" + user + "'");
                if (userdb.Equals("0"))
                {
                    MessageBox.Show("Invalid Username");
                }
                else
                {
                    //passworddb = returnClass.scalarReturn("select count(ad_id) from admin_athu where ad_user='" + user + "' and ad_password='" + pass + "'");
                    string passw = returnClass.scalarReturn("select ad_user from admin_athu where ad_password = '" + txtPassword.Text+"'");
                    if(user.Equals(passw))
                    {
                        string fk_ad_string = returnClass.scalarReturn("select ad_id from admin_athu where ad_user='" + txtUsername.Text + "'");
                        fk_ad = int.Parse(fk_ad_string);
                        txtUsername.Text = "Username";
                        txtPassword.Text= "Password";
                        MenuAdmin menuAdmin = new MenuAdmin();
                        menuAdmin.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
