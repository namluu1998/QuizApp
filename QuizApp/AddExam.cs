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
    public partial class AddExam : UserControl
    {
        public AddExam()
        {
            InitializeComponent();
        }
        public void RefeshForm()
        {
            txtExams.Text = "";
            panel1.Visible = false;
            animation.ShowSync(panel1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (RgEx.isNonCharSpecialAndNonEmpty(txtExams.Text,"Exam name "))
            {
                string query = string.Format("insert into exams values(N'{0}')", txtExams.Text);
                try
                {
                    ReturnClass.ExcuteNonQuery(query,ReturnClass.Status.insert);
                    //MessBox.MessInf()
                    RefeshForm();
                    setDataSource();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
                if (btnHideShow.Name.Equals("0"))
                { btnHideShow.Name = "1"; btnHideShow.Image = Properties.Resources.Next; animation.ShowSync(panelShow);txtFind.Focus(); }
                else
                { btnHideShow.Name = "0"; btnHideShow.Image = Properties.Resources.Back; animation.HideSync(panelShow); }
        }

        private void AddExam_Load(object sender, EventArgs e)
        {
            txtExams.Focus();
            
            setDataSource();
            btnHideShow.Name = "0";
        }
        private void setDataSource()
        {
            string query = "select exam_name from exams";
            DataTable dt = new DataTable();
            ReturnClass.FillAdapter(query, dt);
            GridView.DataSource = dt;

            GridView.Columns[0].Width = GridView.Width;
            GridView.Columns[0].HeaderText = "Tên Môn Học";
        }
        private void FilterTable(string filter)
        {
            try
            {
                (GridView.DataSource as DataTable).DefaultView.RowFilter = filter;
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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            txtFind.text = "";
        }
    }
}
