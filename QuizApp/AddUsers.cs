using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace QuizApp
{
    public partial class AddUsers : UserControl
    {
        public AddUsers()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            btnHideShow.Name = "0";
            txtPassword.Text = "";
            txtRqPw.Text = "";
            txtUsername.Text = "";
            
            panel1.Visible = false;
            animation.ShowSync(panel1);
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {
            Clear();
            string query = string.Format("select * from admin_athu where isAd = 0 or ad_user ='{0}' order by isAd asc", FormLogin.username);
            using (DataTable dt = new DataTable())
            {
                ReturnClass.FillAdapter(query, dt);
                viewUser.DataSource = dt;
            }
            SetDataTable();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //does the username,password contain special character ??? 
            if (cbxTypeUser.selectedIndex == -1) { MessBox.MessError("Please select type User !!!"); return; }
            if (!RgEx.isAlphanumericNotSpace(txtUsername.Text, "Username")) return;
            if(!RgEx.isAlphanumericNotSpace(txtPassword.Text, "Password")) return;
            //Compare Retype the password again
            if (!txtPassword.Text.Equals(txtRqPw.Text)) MessBox.MessError("Retype the password incorrectly !!");
            // insert into Database
            int isadmin = 0;
            if (cbxTypeUser.selectedValue.Equals("Admin")) isadmin = 1;

            string query = String.Format("insert into admin_athu values ('{0}','{1}',{2})", txtUsername.Text, txtPassword.Text, isadmin);
            ReturnClass.ExcuteNonQuery(query, ReturnClass.Status.insert);
        }
        private void Filter(string filter)
        {
            try
            {
                (viewUser.DataSource as DataTable).DefaultView.RowFilter = filter;
            }catch
            {

            }
        }
        private void txtFind_OnTextChange(object sender, EventArgs e)
        {
            string msg = (sender as BunifuTextbox).text;
            string filter = string.Format("ad_user like '%{0}%'", msg);
            Filter(filter);
        }
        private void SetDataTable()
        {
            viewUser.Columns["ad_user"].HeaderText = "Tên User";
            viewUser.Columns["ad_password"].HeaderText = "Password";
            viewUser.Columns["isAd"].HeaderText = "Có phải admin";
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            BunifuImageButton bt = (sender as BunifuImageButton);
            if (bt.Name.Equals("0"))
            { bt.Name = "1"; bt.Image = Properties.Resources.Next; animation.ShowSync(panelShow); txtFind.Focus(); }
            else
            { bt.Name = "0"; bt.Image = Properties.Resources.Back; animation.HideSync(panelShow); }
        }
    }
}
