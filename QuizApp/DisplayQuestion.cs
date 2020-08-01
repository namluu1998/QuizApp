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
using System.Data.SqlClient;
using System.ServiceModel;
//using Client.ChatService;
namespace QuizApp
{
    public partial class DisplayQuestion : UserControl
    {
        PnContentQs pnOps;
        Questions question= new Questions();
        List<int> Examcode = new List<int>();
        string fileName = "";
        ZoomImg zoomImg = new ZoomImg();

        public DisplayQuestion()
        {
            InitializeComponent();
            //Size 694, 589 new Size 1093
        }
        private void SetZoomImage()
        {
            animation.SetDecoration(zoomImg, BunifuAnimatorNS.DecorationType.None);
            zoomImg.Location = new System.Drawing.Point(80, 88);
            zoomImg.Size = new System.Drawing.Size(516, 428);
            zoomImg.TabIndex = 1;
            this.panel1.Controls.Add(zoomImg);
            this.panel1.Controls.SetChildIndex(zoomImg, 0);
        }
        private void setItemCbbExams()
        {
            string query = string.Format("select * from exams");
            List<string> nameExams = new List<string>();
            using (SqlDataReader data = ReturnClass.readerReturn(query))
            {
                while (data.Read())
                {
                    Examcode.Add(data.GetInt32(0));
                    nameExams.Add(data.GetString(1));
                }
            }

            cbxNameExams.Items = nameExams.ToArray();
        }
        private void DisplayQuestion_Load(object sender, EventArgs e)
        {
            eclipse.ApplyElipse(pnMenusQs,30);
            eclipse.ApplyElipse(txtFind, 10);
            //ReceiveClient 
            btnHideShow.Name = "1";
            setItemCbbExams();
            setDataTable();
            SetZoomImage();
            setSwitch(true);
            pnOps = new PnContentQs(PanelAdd, animation, zoomImg);

            eclipse.ApplyElipse(GridView, 10);
            PanelAdd.Controls.SetChildIndex(pnExplain, 0);
        }
        private void setDataTable()
        {
            string query = "select q_id,ex_id,isImage,q_title,exam_name,ad_add,q_addeddate,explain from questions join exams on questions.q_fk_ex = exams.ex_id";
            DataTable dt = new DataTable();
            ReturnClass.FillAdapter(query, dt);
            GridView.DataSource = dt;

            SetHeader();
        }
        private void SetHeader()
        {
            GridView.Columns["q_title"].Width = 300;
            GridView.Columns["q_title"].HeaderText = "Tên Câu Hỏi";
            GridView.Columns["exam_name"].HeaderText = "Tên Môn Học";
            GridView.Columns["ad_add"].HeaderText = "Người Thêm";
            GridView.Columns["q_addeddate"].HeaderText = "Ngày Thêm";
            GridView.Columns["explain"].HeaderText = "Giải thích";

            GridView.Columns["q_id"].Visible = false;
            GridView.Columns["ex_id"].Visible = false;
            GridView.Columns["isImage"].Visible =false;
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            if (btnHideShow.Name.Equals("0"))
            { PanelAdd.Visible = false; animation.ShowSync(pnMenusQs); btnHideShow.Name = "1"; btnHideShow.Image = Properties.Resources.Next; }
            else
            { animation.HideSync(pnMenusQs); btnHideShow.Name = "0"; btnHideShow.Image = Properties.Resources.Back;PanelAdd.Visible = true;   }
        }
        private void FitterText(string formatText)
        {
            try
            {
                (GridView.DataSource as DataTable).DefaultView.RowFilter = formatText;
            }
            catch
            {

            }
        }
        private void txtFind_OnTextChange(object sender, EventArgs e)
        {
            BunifuTextbox txt = sender as BunifuTextbox;
            string checkQs = "";
            if ("False".Contains(txt.text) && !txt.text.Equals("")) checkQs = "or isImage = False";
            else if ("True".Contains(txt.text) && !txt.text.Equals("")) checkQs = "or isImage = True";
            FitterText(string.Format("q_title like '%{0}%' or exam_name like '%{0}%' or ad_add like '%{0}%' {1}", txt.text, checkQs.Equals("") ? "" : checkQs));
        }
        public void RefreshForm()
        {
            panelContents.Visible = false;
            setDataTable();
            txtTitle.Clear();
            animation.ShowSync(panelContents);
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            question.setOption(pnOps.GetOptionSave());
            question.UpdateQuestion();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Questions.DeleteQuestion(int.Parse(question.q_id));
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
        private void setContentQuesTitle(string Content)
        {
            if(switchText.Value) 
                this.txtTitle.Text = Content;
            else
            {
                fileName = Content;
                ptcQs.Image = Image.FromFile(fileName);
            }
        }
        private void DisplayContentQs()
        {
            
            pnOps.SetOption(question.getOption());            
        }
        private void SetContentQs(DataGridViewCellCollection cells)
        {
            //is the content images ?
            setSwitch(!(bool)cells["isImage"].Value);
            //Set title in question
            string Content = cells["q_title"].FormattedValue.ToString();
            setContentQuesTitle(Content);
            question.q_id = cells["q_id"].FormattedValue.ToString();
            question.q_title = Content;
            question.q_addeddate = cells["q_addeddate"].FormattedValue.ToString();
            //Select exam code in Combobox
            int idEx = (int)cells["ex_id"].Value;
            cbxNameExams.selectedIndex = Examcode.FindIndex(x => x == idEx);
            question.q_fk_ex = idEx.ToString();
            question.ad_add = cells["ad_add"].FormattedValue.ToString();
            question.isImage = DataReader.getStringBitDb((bool)cells["isImage"].Value);
            question.explain = cells["explain"].FormattedValue.ToString();
            
        }
        
        public void setSwitch(bool b)
        {
            switchText.Value = b;
            switchText_Click(null, null);
        }
        private void visibleText(bool isText)
        {
            txtTitle.Visible = isText;
            btnOpFd.Visible = !isText;
            ptcQs.Visible = !isText;
            btnClipboard.Visible = !isText;
        }
        private void switchText_Click(object sender, EventArgs e)
        {
            if (switchText.Value == true)
                lblDisplaySwitch.Text = "Texts";
            else
                lblDisplaySwitch.Text = "Images";
            visibleText(switchText.Value);
        }
        private void btnOpFd_Click(object sender, EventArgs e)
        {
            string file = PnContentQs.OpenFileDialog();
            if (!file.Equals(""))
            {
                fileName = file;
                ptcQs.Image = Image.FromFile(file);
            }
        }
        private void btnClipboard_Click(object sender, EventArgs e)
        {
            fileName = PnContentQs.handleBtnClipboadClick(ptcQs);
        }
        private void ptcQs_MouseHover(object sender, EventArgs e)
        {
            pnOps.ZoomImages(sender as PictureBox);
        }

        private void GridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = GridView.Rows[e.RowIndex];
            if ((bool)row.Cells["isImage"].Value && e.ColumnIndex == 3) zoomImg.SetImage(row.Cells["q_title"].FormattedValue.ToString());
            else zoomImg.Visible = false;
        }
        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewCellCollection cell = GridView.CurrentRow.Cells;

            SetContentQs(cell);
            
            btnHideShow_Click(null, null);
            
            DisplayContentQs();
            zoomImg.Visible = false;
        }

        private void btnAddOption_Click(object sender, EventArgs e)
        {
            pnOps.AddPanelQs();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            pnOps.HideLastPanel();
        }
    }
}
