using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    class ResultDataQs
    {
        static ResultDataQs dataQs;

        List<Panel> pnQss = new List<Panel>();

        List<BunifuCustomLabel> lblContents = new List<BunifuCustomLabel>();
        List<BunifuCheckbox> checkOptions = new List<BunifuCheckbox>();
        List<BunifuCheckbox> checkCorrects = new List<BunifuCheckbox>();
        List<PictureBox> imgContents = new List<PictureBox>();
        List<PictureBox> imgContentsOp = new List<PictureBox>();

        ZoomImg zoomImg;

        List<Panel> pnOps = new List<Panel>();
        List<BunifuImageButton> imageButtons = new List<BunifuImageButton>();
        Panel pnContainOptions;
        Panel pnRoot;

        ResultQs resultForm;
        private ResultDataQs() {  }
        
        public static ResultDataQs getInstance()
        {
            if (dataQs == null) dataQs = new ResultDataQs();
            return dataQs;
        }
        public void setResultForm(ResultQs resultQs)
        {
            this.resultForm = resultQs;
        }
        
        public void setPanelRoot(Panel panel)
        {
            pnRoot = panel;
        }
        public void setZoomImg(ZoomImg zoomImg)
        {
            this.zoomImg = zoomImg;
        }
        // 
        // lblOp
        // 
        /** Question **/
        private BunifuImageButton addLabelDetail()
        {
            BunifuImageButton lblDetail = new BunifuImageButton();
            lblDetail.BackColor = System.Drawing.Color.Transparent;
            lblDetail.Image = Properties.Resources.chevron_down;
            lblDetail.ImageActive = null;
            lblDetail.Location = new System.Drawing.Point(488, 45);
            lblDetail.Size = new System.Drawing.Size(36, 35);
            lblDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            lblDetail.TabStop = false;
            lblDetail.Zoom = 10;
            lblDetail.Click += new System.EventHandler(this.lblDetail_Click);

            imageButtons.Add(lblDetail);

            return lblDetail;
        }
        private BunifuCustomLabel addLabelQs(string text)
        {
            BunifuCustomLabel lblQs = new BunifuCustomLabel();
            lblQs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblQs.Location = new System.Drawing.Point(98, 14);
            lblQs.Size = new System.Drawing.Size(328, 96);
            lblQs.Text = text;
            lblQs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            while (lblQs.Height < System.Windows.Forms.TextRenderer.MeasureText(lblQs.Text,
            new Font(lblQs.Font.FontFamily, lblQs.Font.Size, lblQs.Font.Style)).Height)
            {
                lblQs.Font = new Font(lblQs.Font.FontFamily, lblQs.Font.Size - 0.5f, lblQs.Font.Style);
            }
            return lblQs;
        }
        private BunifuCheckbox addCheckQs(bool isTrue)
        {
            BunifuCheckbox Check = new BunifuCheckbox();
            Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            Check.Checked = isTrue;
            Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            Check.ForeColor = System.Drawing.Color.White;
            Check.Location = new System.Drawing.Point(432, 56);
            Check.Size = new System.Drawing.Size(20, 20);
            Check.Enabled = false;
            
            return Check;
        }
        private PictureBox addPtcQs(string fileName)
        {
            PictureBox ptcQs = new PictureBox();
            ptcQs.Location = new System.Drawing.Point(170, 18);
            ptcQs.Image = Image.FromFile(fileName);
            ptcQs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ptcQs.Size = new System.Drawing.Size(162, 85);
            ptcQs.TabIndex = 0;
            ptcQs.TabStop = false;
            ptcQs.MouseHover += new System.EventHandler(this.ptc_MouseHover);
            imgContents.Add(ptcQs);
            return ptcQs;
        }
        public void addPanelQs(Questions qs, bool isTrue)
        {
            if (pnRoot == null) return;
            Panel pnQs = new Panel();
            pnQs.BackColor = System.Drawing.Color.Transparent;
            pnQs.BackgroundImage = global::QuizApp.Properties.Resources.ResultQs;
            pnQs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnQs.Controls.Add(addLabelDetail());
            pnQs.Controls.Add(addCheckQs(isTrue));
            string Content = qs.q_title;
            pnQs.Controls.Add(DataReader.getBooleanInStringBit(qs.isImage) ? (Control)addPtcQs(Content) : (Control)addLabelQs(Content));
            pnQs.Dock = System.Windows.Forms.DockStyle.Top;
            pnQs.Location = new System.Drawing.Point(0, 0);
            pnQs.Size = new System.Drawing.Size(542, 113);

            pnQss.Add(pnQs);

            pnRoot.Controls.Add(pnQs);
            pnRoot.Controls.SetChildIndex(pnQs, 0);
        }
        public void Clear()
        {
            pnOps.Clear();
            //pnQss.Clear();
        }
        private bool CheckCorrectQuestion(List<Options> option,List<bool> check)
        {
            for (int index = 0; index < check.Count; ++index)
                if (!option[index].isCorrect.Equals(DataReader.getStringBitDb(check[index])))return false;
            return true;
        }

        public double InitQuestion(List<Questions> questions)
        {
            double isCorrect = 0;
            QA qa = QA.getInstance();
            for (int index = 0;index < questions.Count ; ++index)
            {
                bool isTrue = CheckCorrectQuestion(questions[index].getOption(), qa.check[index]);
                addPanelQs(questions[index], isTrue);
                if (isTrue) ++isCorrect;
            }
            return (isCorrect/questions.Count)*10;

        }
        /** Option **/
        public void setPanelOptionRoot(Panel pnContainOption)
        {
            this.pnContainOptions = pnContainOption;
        }
        private bool isNullPanelContainOption()
        {
            if (pnContainOptions == null) return true;
            return false;
        }
        private PictureBox addImageOption()
        {
            PictureBox ptcOp = new PictureBox();
            ptcOp.BackColor = System.Drawing.Color.Transparent;
            ptcOp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ptcOp.Location = new System.Drawing.Point(163, 8);
            ptcOp.Size = new System.Drawing.Size(159, 60);
            ptcOp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ptcOp.TabStop = false;
            ptcOp.MouseHover += new System.EventHandler(this.ptc_MouseHover);

            imgContentsOp.Add(ptcOp);

            return ptcOp;
        }
        private BunifuCheckbox addCheckOption(bool isCorrect)
        {
            BunifuCheckbox checkOp = new BunifuCheckbox();
            checkOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            if (isCorrect)
                checkOp.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            else
                checkOp.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            checkOp.Checked = true;
            checkOp.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            checkOp.ForeColor = System.Drawing.Color.White;
            int locationX = isCorrect == true ? 0 : 40;
            checkOp.Location = new System.Drawing.Point(432 + locationX, 32);
            checkOp.Size = new System.Drawing.Size(20, 20);
            checkOp.Enabled = false;

            if (isCorrect) checkCorrects.Add(checkOp);
            else checkOptions.Add(checkOp);

            return checkOp;
        }
        private BunifuCustomLabel addLabelOption()
        {
            BunifuCustomLabel lblResult = new BunifuCustomLabel();
            lblResult.BackColor = System.Drawing.Color.Transparent;
            lblResult.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblResult.Location = new System.Drawing.Point(98, 1);
            lblResult.Size = new System.Drawing.Size(330, 80);
            lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            lblContents.Add(lblResult);
            return lblResult;
        }
        public void addPanelParentOption(int index)
        {
            if (isNullPanelContainOption()) return;
            System.Windows.Forms.Panel pnContentOption = new System.Windows.Forms.Panel();
            pnContentOption.BackgroundImage = global::QuizApp.Properties.Resources.Result;
            pnContentOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnContentOption.Controls.Add(addImageOption());
            pnContentOption.Controls.Add(addLabelOption());
            pnContentOption.Controls.Add(addCheckOption(true));
            pnContentOption.Controls.Add(addCheckOption(false));
            pnContentOption.Dock = DockStyle.Top;
            pnContentOption.Location = new System.Drawing.Point(0, 113);
            pnContentOption.Size = new System.Drawing.Size(542, 81);
            pnContentOption.Visible = true;
            //pnOps.Add(pnDetail);

            this.pnContainOptions.Controls.Add(pnContentOption);
            this.pnContainOptions.Controls.SetChildIndex(pnContentOption, 0);
            //int index = this.pnRoot.Controls.GetChildIndex(this.PanelQsClick);
            //pnRoot.Controls.Add(pnDetail);
            //pnRoot.Controls.SetChildIndex(pnDetail, index);
        }
        private void DisplayCheckOp(int index ,bool choose,bool correct)
        {
            checkOptions[index].Checked = choose;
            checkCorrects[index].Checked = correct;
        }
        private void DisplayContentOption(int index,Options option)
        {
            string Content = option.Contents;
            if(DataReader.getBooleanInStringBit(option.isImages))
            {
                imgContentsOp[index].Image = Image.FromFile(Content);
                imgContentsOp[index].Visible = true;
                lblContents[index].Visible=false;
            }
            else
            {
                lblContents[index].Text = Content;
                imgContentsOp[index].Visible = false;
                lblContents[index].Visible = true;
            }
        }
        public void DisplayOption(Questions question,List<bool> Check,List<int>OptionMix)
        {
            List<Options> options = question.getOption();
            //QA qa = QA.getInstance().check
            for(int index=0;index<options.Count;++index)
            {
                if (index >= lblContents.Count) addPanelParentOption(index+1);
                int indexMix = OptionMix[index];
                DisplayContentOption(index,options[indexMix]);
                DisplayCheckOp(index, Check[indexMix], DataReader.getBooleanInStringBit(options[indexMix].isCorrect));
            }
        }
        public void ZoomImage(object sender)
        {
            ptc_MouseHover(sender, null);
        }
        private void ptc_MouseHover(object sender, EventArgs e)
        {
            if (zoomImg == null) return;
            zoomImg.SetImage(sender as PictureBox);
        }
        private void OffVisibleOp()
        {
            pnOps.ForEach(x => x.Visible = false);
        }
        private void lblDetail_Click(object sender, EventArgs e)
        {
            OffVisibleOp();
            BunifuImageButton button = sender as BunifuImageButton;
            int index = imageButtons.FindIndex(x => x.Equals(button));
            if (index == -1) return;
            
            DisplayOption(QA.getInstance().getQuestion(index),QA.getInstance().check[index],QA.getInstance().optionMix[index]);
            resultForm.setContentQuestion(index);
            //pnRoot.Controls.Remove(pnQss[index]);
            //this.PanelQsClick = pnQss[index];
            //SetContentOption(question[index], check[index]);
        }
    }
}
