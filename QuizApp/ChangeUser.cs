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
    public partial class ChangeUser : UserControl
    {
        public ChangeUser()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            btnHideShow.Name = "0";
            txtFind.text = "";
            txtPassword.Text = "";
            txtRqPw.Text = "";
            txtUsername.Text = "";

            panelShow.Visible = false;
            btnHideShow_Click(btnHideShow, null);
        }
        string oldUsername = "";
        string img = "";
        private void setDataTable()
        {
            string query = string.Format("select * from admin_athu where isAd = 0 or ad_user ='{0}' order by isAd asc", FormLogin.username);
            viewUser.DataSource = HandleGrView.GetDataSource(query);

            viewUser.Columns["ad_password"].Visible = false;
            viewUser.Columns["Images"].Visible = false;
            viewUser.Columns["ad_user"].HeaderText = "Username";
            viewUser.Columns["isAd"].HeaderText = "Có phải admin";
            viewUser.Columns["FullName"].HeaderText = "Tên";
            viewUser.Columns["Live"].HeaderText = "Nơi Sống";
            viewUser.Columns["DateOfBirth"].HeaderText = "Ngày Sinh";
            viewUser.Columns["PhoneNumber"].HeaderText = "Số Điện Thoại";
        }
        private string CellContent(DataGridViewCell cell)
        {
            return cell.FormattedValue.ToString() ?? "";
        }
        private void ChangeUser_Load(object sender, EventArgs e)
        {
            setDataTable();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            txtFind.text = "";
        }

        private void txtFind_OnTextChange(object sender, EventArgs e)
        {
            string msg = (sender as BunifuTextbox).text;
            string filter = string.Format("ad_user like '%{0}%' or isAd = {0}", msg);
            HandleGrView.FilterDataTable(viewUser.DataSource as DataTable,filter);
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            BunifuImageButton bt = (sender as BunifuImageButton);
            if (bt.Name.Equals("0"))
            { img = ""; oldUsername = ""; animation.HideSync(panel4); bt.Name = "1"; bt.Image = Properties.Resources.Back; animation.ShowSync(panelShow); txtFind.Focus(); }
            else
            {bt.Name = "0"; bt.Image = Properties.Resources.Next; animation.HideSync(panelShow);animation.ShowSync(panel4); }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldUsername)) return;
            string query = string.Format("update admin_athu set ad_user = '{0}',ad_password='{1}',FullName=N'{2}',Live =N'{3}',DateOfBirth = '{4}',PhoneNumber ='{5}',Images='{6}' where ad_user = '{7}'",
                txtUsername.Text, txtPassword.Text, txtFullName.Text, txtLive.Text, txtDate.Value.ToShortDateString(), txtPhoneNum.Text, img,oldUsername);
            ReturnClass.ExcuteNonQuery(query,ReturnClass.Status.update);
        }

        private void btnOpenFd_Click(object sender, EventArgs e)
        {
            img = PnContentQs.OpenFileDialog();
            ptcUser.Image = Image.FromFile(img);
        }
        private DateTime getDateTime(DataGridViewCell cell)
        {
            try
            {
                return (DateTime)cell.Value;
            }catch
            {
                return DateTime.Today;
            }
        }

        private void viewUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cells = (sender as BunifuCustomDataGrid).CurrentRow.Cells;
            oldUsername = txtUsername.Text = CellContent(cells["ad_user"]);
            txtRqPw.Text= txtPassword.Text = CellContent(cells["ad_password"]);
            txtFullName.Text = CellContent(cells["FullName"]);
            txtLive.Text = CellContent(cells["Live"]);
            txtDate.Value = getDateTime(cells["DateOfBirth"]);
            txtPhoneNum.Text = CellContent(cells["PhoneNumber"]);
            ptcUser.Image = string.IsNullOrEmpty(CellContent(cells["Images"])) ? Properties.Resources.businesswoman : Image.FromFile(CellContent(cells["Images"]));

            btnHideShow_Click(btnHideShow, null);
        }
    }
}
