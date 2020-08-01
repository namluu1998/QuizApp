using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bunifu.Framework.UI;

namespace QuizApp
{
    public partial class ChangeExam : UserControl
    {
        int idEx = 0;
        public ChangeExam()
        {
            InitializeComponent();
        }

        private void ChangeExam_Load(object sender, EventArgs e)
        {
            btnHideShow.Name = "1";
            setDataSource();
        }
        public void InitEx()
        {
            panelShow.Visible = false;
            animation.ShowSync(panelShow);
        }
        private void setDataSource()
        {
            string query = "select * from exams";
            DataTable dt = new DataTable();
            ReturnClass.FillAdapter(query, dt);
            viewExams.DataSource = dt;

            viewExams.Columns["ex_id"].Visible = false;

            viewExams.Columns["exam_name"].Width = viewExams.Width;
            viewExams.Columns["exam_name"].HeaderText = "Tên Môn Học";
        }
        private bool CheckContent()
        {
            if (RgEx.isEmpty(txtExams.Text, "Tên Môn Học")) { return false; }
            if (this.idEx == 0) { MessBox.MessError("Please choose exam!! "); return false; }
            return true;
        }
        private void btnSaved_Click(object sender, EventArgs e)
        {
            if (!CheckContent()) return;
            string query = string.Format("update exams set exam_name = '{0}' where ex_id = {1}",txtExams.Text,this.idEx);
            ReturnClass.ExcuteNonQuery(query,ReturnClass.Status.update);
        }

        private void viewExams_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dt = viewExams.CurrentRow;
            this.idEx = int.Parse(dt.Cells[0].FormattedValue.ToString());
            txtExams.Text = dt.Cells["exam_name"].FormattedValue.ToString();
            btnHideShow_Click(null, null);
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            if (btnHideShow.Name.Equals("0"))
            { btnHideShow.Name = "1"; btnHideShow.Image = Properties.Resources.Next; animation.ShowSync(panelShow); txtFind.Focus(); }
            else
            { btnHideShow.Name = "0"; btnHideShow.Image = Properties.Resources.Back; animation.HideSync(panelShow); }
        }
        private void FilterTable(string filter)
        {
            try
            {
                (viewExams.DataSource as DataTable).DefaultView.RowFilter = filter;
            }
            catch
            {
            }
        }
        private void txtFind_OnTextChange(object sender, EventArgs e)
        {
            string msg = (sender as BunifuTextbox).text;
            string filter = string.Format("exam_name like '%{0}%'", msg);
            FilterTable(filter);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!CheckContent()) return;
            List<int> q_id = new List<int>();
            string query = string.Format("select q_id from questions where q_fk_ex =2");
            using (SqlDataReader reader = ReturnClass.readerReturn(query))
            {
                while(reader.Read())
                {
                    q_id.Add(reader.GetInt32(0));
                }
            }
        }
    }
}
