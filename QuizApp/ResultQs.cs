using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class ResultQs : UserControl
    {
        Panel currentPanelQs;
        List<Questions> questions;
        ResultDataQs resultData = ResultDataQs.getInstance();
        StartForm parentForm;
        public ResultQs(StartForm parent)
        {
            this.parentForm = parent;
            InitializeComponent();
        }

        private void ResultQs_Load(object sender, EventArgs e)
        {
            
        }
        public void LoadData()
        {
            resultData.setResultForm(this);
            resultData.setPanelRoot(pnContent);
            resultData.setPanelOptionRoot(pnContainOptions);
            questions = QA.getInstance().getQuestions();
            
            double score =resultData.InitQuestion(questions);
            lblScore.Text = score.ToString();
            percent.Value = (int)score * 10;
        }
        public void setContentQuestion(int index)
        {
            QA qa = QA.getInstance();
            Questions qs = qa.getQuestion(index);
            ptcQs.Visible = false;
            lblQs.Visible = false;
            if (DataReader.getBooleanInStringBit(qs.isImage)) { ptcQs.Image = Image.FromFile(qs.q_title); ptcQs.Visible = true; }
            else { lblQs.Text = qs.q_title; lblQs.Visible = true; }
            animation.HideSync(pnContent);
        }
        private void ptcQs_MouseHover(object sender, EventArgs e)
        {
            resultData.ZoomImage(sender);
        }

        private void ptcOp_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            if (pnContent.Visible == false) animation.ShowSync(pnContent);
            else parentForm.Close();
        }
    }
}
