using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class StartForm : Form
    {
        ResultQs resultQs;
        string fileName;
        long time;
        public StartForm()
        {
            InitializeComponent();
        }

        private void ApplyEclipse()
        {
            Eclipse.ApplyElipse(pnRoot, 30);
        }
        private void StartForm_Load(object sender, EventArgs e)
        {
            resultQs = new ResultQs(this);
            this.KeyPreview = true;

            ApplyEclipse();
            this.Eclipse.ApplyElipse(this, 40);

            QA.getInstance().setPanel(panelRootOption,zoomImg1);
            ResultDataQs.getInstance().setZoomImg(zoomImg1);

            SetResultData();
            pnRoot.Controls.SetChildIndex(zoomImg1, 0);

            time = QA.getInstance().getTime();
            if (time!=0)
            {
                timer1_Tick(null, null);
                timer1.Start();
            }
            Init();
        }
        public void Init()
        {
            btnNext_Click(btnNext, null);
        }
        public void SetResultData()
        {
            resultQs.Dock = System.Windows.Forms.DockStyle.Fill;
            resultQs.Location = new System.Drawing.Point(0, 0);
            resultQs.Size = new System.Drawing.Size(626, 858);
            pnRoot.Controls.Add(resultQs);
            pnRoot.Controls.SetChildIndex(resultQs, 0);
            resultQs.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time-- == 0)
            {
                btnSubmit_Click(btnSubmit, null);
            }
            else
            {
                lblTimes.Text = (time / 60) + " : " + (time % 60);
            }
        }

        private void setContentTilte()
        {
            bool isImage = DataReader.getBooleanInStringBit(QA.getInstance().GetQuestions().isImage);
            string Content = QA.getInstance().GetQuestions().q_title;
            fileName = Content;
            lblTitle.Visible = !isImage;
            ptcQs.Visible = isImage;
            if (ptcQs.Visible) ptcQs.Image = Image.FromFile(Content);
            else lblTitle.Text = Content;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            lblIndex.Text = QA.getInstance().backStep();
            setContentTilte();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblIndex.Text =  QA.getInstance().nextStep();
            setContentTilte();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            animation.ShowSync(resultQs);
            resultQs.LoadData();
        }

        private void StartForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true)
                if (e.KeyCode == Keys.Right)
                    btnNext_Click(null, null);
                else if (e.KeyCode == Keys.Left)
                    btnBack_Click(null, null);
        }

        private void StartForm_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            if(MessBox.MessWarning("Return to the menu and cancel the test ???"))this.Close();
        }


        private void ptcQs_MouseHover(object sender, EventArgs e)
        {
            zoomImg1.SetImage(fileName);
        }

    }
}
