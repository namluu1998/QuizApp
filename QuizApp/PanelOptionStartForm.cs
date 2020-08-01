using Bunifu.Framework.UI;
using BunifuAnimatorNS;
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
    class PanelOptionStartForm
    {
        int LocationY = 130;
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<BunifuThinButton2> BtnContents = new List<BunifuThinButton2>();
        List<BunifuCheckbox> checkboxes = new List<BunifuCheckbox>();
        List<BunifuImageButton> imageButtons = new List<BunifuImageButton>();
        List<Panel> panels = new List<Panel>();
        Panel rootPanel;
        List<bool> check = new List<bool>();
        List<int> optionInt = new List<int>();
        ZoomImg zoomImg;
        public PanelOptionStartForm(Panel rootPanel,ZoomImg zoomImg) 
        {
            this.rootPanel = rootPanel;
            this.zoomImg = zoomImg;
        }
        private void RandStyleButton()
        {
            if (BtnContents.Count == 0) return;
            int index = BtnContents.Count-1;
            switch (index%4)
            {
                case 0:
                    BtnContents[index].ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(176)))), ((int)(((byte)(247)))));
                    break;
                case 1:
                    BtnContents[index].ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
                    break;
                case 2:
                    BtnContents[index].ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(176)))), ((int)(((byte)(247)))));
                    break;
                case 3:
                    BtnContents[index].ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(124)))), ((int)(((byte)(175)))));
                    break;
            }

        }
        private BunifuThinButton2 addButtonContentIntopanel()
        {
            BunifuThinButton2 btnContent = new BunifuThinButton2();
            btnContent.IdleForecolor = System.Drawing.Color.DarkSeaGreen;
            btnContent.ActiveLineColor = System.Drawing.Color.DarkCyan;
            btnContent.ActiveForecolor = System.Drawing.Color.White;
            btnContent.IdleFillColor = System.Drawing.Color.White;
            btnContent.IdleLineColor = System.Drawing.Color.Black;
            btnContent.ActiveBorderThickness = 1;
            btnContent.ActiveCornerRadius = 20;
            btnContent.BackColor = System.Drawing.Color.Transparent;
            btnContent.Cursor = System.Windows.Forms.Cursors.Hand;
            btnContent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnContent.ForeColor = System.Drawing.Color.DarkSlateGray;
            btnContent.IdleBorderThickness = 1;
            btnContent.IdleCornerRadius = 20;
            
            btnContent.Location = new System.Drawing.Point(28, 6);
            btnContent.Margin = new System.Windows.Forms.Padding(5);
            btnContent.Size = new System.Drawing.Size(399, 106);
            btnContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            btnContent.Click += new System.EventHandler(this.Button_Click);

            BtnContents.Add(btnContent);

            RandStyleButton();

            return btnContent;

        }
        private BunifuCheckbox addCheckBoxIntopanel()
        {
            BunifuCheckbox checkOption = new BunifuCheckbox();
            checkOption.BackColor = System.Drawing.Color.IndianRed;
            checkOption.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            checkOption.Checked = true;
            checkOption.CheckedOnColor = System.Drawing.Color.IndianRed;
            checkOption.ForeColor = System.Drawing.Color.White;
            checkOption.Location = new System.Drawing.Point(3, 54);
            checkOption.Size = new System.Drawing.Size(20, 20);

            checkboxes.Add(checkOption);

            return checkOption;

        }
        private BunifuImageButton addImageButtonIntoPanel()
        {
            BunifuImageButton ptcContent = new BunifuImageButton();
            ptcContent.BackColor = System.Drawing.Color.Transparent;
            ptcContent.ImageActive = null;
            ptcContent.Location = new System.Drawing.Point(68, 14);
            ptcContent.Size = new System.Drawing.Size(177, 96);
            ptcContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ptcContent.TabStop = false;
            ptcContent.Zoom = 10;
            ptcContent.Click += new System.EventHandler(this.imageButton_Click);
            ptcContent.MouseHover += new System.EventHandler(this.ptcContent_MouseHover);

            imageButtons.Add(ptcContent);

            return ptcContent;

        }
        private void AddPanel(int index)
        {
            Panel panelOption = new Panel();
            panelOption.Controls.Add(addImageButtonIntoPanel());
            panelOption.Controls.Add(addCheckBoxIntopanel());
            panelOption.Controls.Add(addButtonContentIntopanel());
            panelOption.Location = new System.Drawing.Point(90, 3+this.LocationY*index);
            panelOption.Size = new System.Drawing.Size(435, 124);
            panelOption.Visible =true;
            panels.Add(panelOption);

            rootPanel.Controls.Add(panelOption);
        }
        private void VisibleComponent(int index,bool isImage)
        {
            panels[index].Visible = true;
            BtnContents[index].Visible = !isImage;

            imageButtons[index].Visible = isImage;
            
        }
        private void DisplayComponent(int index,bool isImage,string content,bool isCorrect)
        {
            VisibleComponent(index, isImage);
            ContentComponent(index, content);
            DisplayCorrect(index, isCorrect);
        }
        private void ContentComponent(int index,string content)
        {
            if(imageButtons[index].Visible)
                imageButtons[index].Image = Image.FromFile(content);
            else BtnContents[index].ButtonText = content;
        }
        private void DisplayCorrect(int index,bool check)
        {
            checkboxes[index].Checked = check;
        }
        private void OffAllPanel(BunifuTransition animation)
        {
            for (int i = 0; i < panels.Count && panels[i].Visible == true; ++i)
            {
                animation.HideSync(BtnContents[i]);
                panels[i].Visible = false;
            }
        }
        private void OffPanel(int num)
        {
            for (int i = num; i < panels.Count && panels[i].Visible == true; ++i)
                panels[i].Visible =false;

        }
        public static bool CheckTextQs(int qs)
        {
            string query = string.Format("select isImage from questions where q_id = {0}", qs);
            return ReturnClass.scalarReturn(query).Equals("True") ? false : true;
        }
        public static List<string> getContentOption(string qs, List<string> Contents,List<bool>check)
        {
            string msg = "Contents";
            if (check != null) msg += ",isCorrect";

            string query = string.Format("select {0} from Options where id_Qus ={1}",msg, qs);
            using (SqlDataReader reader = ReturnClass.readerReturn(query))
            {
                while (reader.Read())
                {
                    Contents.Add(reader.GetString(0));
                    if (check != null) check.Add(reader.GetBoolean(1));
                }
            }
            return Contents;
        }
        public void CreatePanel(int numPn)
        {
            for(int i=0;i<numPn;++i)
                AddPanel(i);
        }
        public void DisplayOption(string idQues,List<int> optionMix,List<bool> check,List<Options> options)
        {
            this.check = check;

            optionInt = optionMix;
            OffPanel(options.Count);
            for (int i = 0; i < options.Count; ++i)
            {
                if (i >= panels.Count) AddPanel(i);
                int indexOption = optionMix[i];
                DisplayComponent(i, DataReader.getBooleanInStringBit(options[indexOption].isImages), options[indexOption].Contents, check[indexOption]);
            }
        }
        private void imageButton_Click(object sender, EventArgs e)
        {
            FindSelected(sender, false);
        }
        public void Button_Click(object sender, EventArgs e)
        {
            FindSelected(sender,true);
        }
        private void FindSelected(object sender ,bool isText)
        {
            int indexUI = isText == true ? BtnContents.FindIndex(x => x == sender) : imageButtons.FindIndex(x => x == sender);
            int indexContent = optionInt[indexUI];
            checkboxes[indexUI].Checked = !checkboxes[indexUI].Checked;
            check[indexContent] = checkboxes[indexUI].Checked;
        }
        private void ptcContent_MouseHover(object sender, EventArgs e)
        {
            int index =imageButtons.FindIndex(x => x == sender);
            if (index == -1) return;   
            zoomImg.SetImage((sender as BunifuImageButton).Image);
        }
    }
}
