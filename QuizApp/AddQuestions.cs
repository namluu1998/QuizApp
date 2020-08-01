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
using System.IO;

namespace QuizApp
{
    public partial class AddQuestions : UserControl
    {
        List<int> Examcode = new List<int>();
        PnContentQs pnOps;
        public static int indexOption = 0;
        string fileName = "";
        ZoomImg zoomImg;
        public AddQuestions()
        {
            InitializeComponent();
        }
        private void SetZoomImage()
        {
            zoomImg = new ZoomImg();
            animation.SetDecoration(zoomImg, BunifuAnimatorNS.DecorationType.None);
            zoomImg.Location = new System.Drawing.Point(80, 88);
            zoomImg.Size = new System.Drawing.Size(516, 428);
            zoomImg.TabIndex = 1;
            this.panel1.Controls.Add(zoomImg);
            this.panel1.Controls.SetChildIndex(zoomImg, 0);
        }
        private void AddQuestions_Load(object sender, EventArgs e)
        {
            SetZoomImage();
            pnOps = new PnContentQs(pnOptions, animation, zoomImg);
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
            switchText_Click(null,null);
            pnOptions.Controls.SetChildIndex(pnExplain, 0);
        }
        public void Clear()
        {
            rtxExplain.Clear();
            ptcQs.Image = null;
            rtxtQuestion.Clear();
            pnOps.Clear();
            panel1.Visible = false;
            animation.ShowSync(panel1);
        }
        private bool CheckEmpty(string str)
        {
            return str == "" ? true : false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string contents = switchText.Value ? rtxtQuestion.Text : fileName;
            if (RgEx.isEmpty(contents, "Title question")) return;
            if (!pnOps.getCountOpValid()) return;
            if (cbxNameExams.selectedIndex == -1) { MessBox.Warning("Please Select Exams!!"); return; }


            /*Insert Question*/
            Questions qs = new Questions(contents, DateTime.UtcNow.ToShortDateString(), Examcode[cbxNameExams.selectedIndex].ToString(),
                FormLogin.username, switchText.Value == true ? "0" : "1", rtxExplain.Text);
            qs.setOption(pnOps.GetOption());
            qs.InsertQuestion();

            Clear();
        }

        private void btnAddOption_Click(object sender, EventArgs e)
        {
            pnOps.AddPanelQs();
        }

        private void btnDelQs_Click(object sender, EventArgs e)
        {
            pnOps.HideLastPanel();
        }

        public void setSwitch(bool b)
        {
            switchText.Value = b;
            switchText_Click(null, null);
        }
        private void visibleText(bool isText)
        {
            rtxtQuestion.Visible = isText;
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

        private void AddQuestions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true )
            {
                if (e.KeyCode == Keys.Enter)
                    btnAddOption_Click(null, null);
                else if (e.KeyCode == Keys.Delete)
                   btnDelQs_Click(null, null);
                if (e.KeyCode == Keys.Down)
                    setSwitch(!switchText.Value);
                //if (e.KeyCode == Keys.C && e.Shift == true)
                //    formAddExams.Clear();
            }
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

        private void pnOptions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            fileName = PnContentQs.handleBtnClipboadClick(ptcQs);
        }

        private void ptcQs_MouseHover(object sender, EventArgs e)
        {
            pnOps.ZoomImages(sender as PictureBox);
        }

        private void ptcQs_MouseLeave(object sender, EventArgs e)
        {
            //zoomImg.SetImage(sender, false);
        }
    }
}
