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
using System.Data.SqlClient;
using System.IO;

namespace QuizApp
{
    public partial class FormLogin : Form
    {
        public static int fk_ad;
        public static string username="";
        AdminForm formAdmin;
        FormStudents formStudents;

        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void ptcExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtPassword.UseSystemPasswordChar = true;
            ptcPassword.BackgroundImage = Properties.Resources.unlock;
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") { txtPassword.Text = "Password"; txtPassword.UseSystemPasswordChar = false; }
            else txtPassword.UseSystemPasswordChar = true;
            ptcPassword.BackgroundImage = Properties.Resources.unlock1;
            txtPassword.ForeColor = Color.WhiteSmoke;
            panel2.ForeColor = Color.WhiteSmoke;
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            if (user.Equals("Username") || pass.Equals("Password")) { MessBox.MessError("Username or Password is Empty !!"); return; }
            if (!RgEx.isAlphanumericNotSpace(user,"Username"))
                return;
            if (!RgEx.isAlphanumericNotSpace(pass, "Password"))
                return;
            //MessBox.MessInf(isAd);
            string query = string.Format("select isAd from admin_athu where ad_user='{0}' and ad_password='{1}'", user, pass);
            string isAd = ReturnClass.scalarReturn(query);
            
            //Check invalid User or password
            if (isAd.Equals("")) { MessBox.MessError("Invalid Input User or Password"); return; }
            //Hide old form login and show form Admin or Students
            try
            {
                this.Hide();
                if (isAd.Equals("True"))
                {
                    username = user;
                    formAdmin.ShowDialog();
                }
                else formStudents.ShowDialog();
                this.Show();
            }catch
            {

            }
        }


        private void FormLogin_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1D;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //ZoomImg img = new ZoomImg();
            //img.Dock = DockStyle.Fill;
            //img.SetBounds(20, 20, 150, 70);
            //this.Controls.Add(img);
            //this.Controls.SetChildIndex(img, 0);
            //MessageBox.Show();
            //qs.UpdateQuestion();
            /*Delete*/
            /*Insert Option in Question*/
            //Options op = new Options("int", "12", "0", "1");
            //op.insertOption();
            this.KeyPreview = true;
            formAdmin = new AdminForm();
            formStudents = new FormStudents();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)btnLogin_Click(btnLogin, null);
        }

        private void timeStart_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.025;
            else timeStart.Stop();
        }
    }
}
