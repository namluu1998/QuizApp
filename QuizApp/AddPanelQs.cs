using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace QuizApp
{
    class AddPanelQs
    {
        List<BunifuCheckbox> checkBoxOptions;
        List<RichTextBox> rtx;
        List<Panel> panelOption;
        List<BunifuImageButton> btnOpenFolder;
        List<PictureBox> pictureOption;
        List<string> fileNames;
        int indexOption = 0;
        private AddPanelQs() { }
        public AddPanelQs(List<BunifuCheckbox> checkBoxOptions, List<RichTextBox> rtx, List<BunifuImageButton> btnOpenFolder, List<PictureBox> pictureOption, List<string> fileNames, List<Panel> panelOption)
        {
            this.checkBoxOptions = checkBoxOptions;
            this.rtx = rtx;
            this.btnOpenFolder = btnOpenFolder;
            this.pictureOption = pictureOption;
            this.fileNames = fileNames;
            this.panelOption = panelOption;
        }
        public void setVisiblePanel(List<Panel> panel,bool value)
        {
            foreach (var dt in panel)
                if (dt.Visible == value) break;
                else dt.Visible = value;
        }
        private void CheckText(int index,bool check,string content)
        {
            rtx[index].Visible = check;
            if (check) rtx[index].Text = content;
        }
        private void CheckImages(int index,bool check,string content)
        {
            try
            {
                fileNames[index] = content;
                btnOpenFolder[index].Visible = check;
                pictureOption[index].Visible = check;
                
                if (check)
                    pictureOption[index].Image = Image.FromFile(content);
            }
            catch
            {

            }
        }
        public void setVisibleContent(int index,string content,bool check,bool isImages)
        {
            CheckText(index, !isImages,content);
            CheckImages(index, isImages,content);
            checkBoxOptions[index].Checked = check;
        }
        public void addCorrect(Panel panel)
        {
            BunifuCheckbox CheckCorrect = new BunifuCheckbox();
            CheckCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            CheckCorrect.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            CheckCorrect.Checked = false;
            CheckCorrect.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            CheckCorrect.ForeColor = System.Drawing.Color.White;
            CheckCorrect.Location = new System.Drawing.Point(0, 46);
            CheckCorrect.Size = new System.Drawing.Size(20, 20);
            checkBoxOptions.Add(CheckCorrect);
            panel.Controls.Add(CheckCorrect);
        }
        public void addLabelOptions(Panel panel)
        {
            Label lblAddOption = new Label();
            lblAddOption.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAddOption.ForeColor = System.Drawing.Color.DimGray;
            lblAddOption.Location = new System.Drawing.Point(27, 40);
            lblAddOption.Size = new System.Drawing.Size(133, 35);
            lblAddOption.Text = String.Format("Option {0} :", ++indexOption);
            lblAddOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            panel.Controls.Add(lblAddOption);
        }
        public RichTextBox addTextBoxOption(Panel panel)
        {
            RichTextBox txtOption = new RichTextBox();
            txtOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            txtOption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtOption.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtOption.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            txtOption.Location = new System.Drawing.Point(169, 23);
            txtOption.Size = new System.Drawing.Size(466, 61);
            txtOption.TabIndex = 81;
            txtOption.Text = "";

            rtx.Add(txtOption);

            panel.Controls.Add(txtOption);
            return txtOption;
        }
        public BunifuImageButton addButtonOpenFolder(Panel panel)
        {
            BunifuImageButton OpenFolder = new BunifuImageButton();
            OpenFolder.BackColor = System.Drawing.Color.Transparent;
            OpenFolder.Image = Properties.Resources.opened_folder;
            OpenFolder.ImageActive = null;
            OpenFolder.Location = new System.Drawing.Point(430, 35);
            OpenFolder.Size = new System.Drawing.Size(51, 49);
            OpenFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            OpenFolder.TabStop = false;
            OpenFolder.Zoom = 10;
            OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);

            btnOpenFolder.Add(OpenFolder);

            panel.Controls.Add(OpenFolder);
            return OpenFolder;
        }
        public PictureBox addPictureBox(Panel panel)
        {
            //Init Picture Box 
            PictureBox ptcImageContent = new PictureBox();
            ptcImageContent.Image = Properties.Resources.addImages;
            ptcImageContent.Location = new System.Drawing.Point(192, 3);
            ptcImageContent.Size = new System.Drawing.Size(173, 94);
            ptcImageContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ptcImageContent.TabStop = false;
            //Add 
            fileNames.Add("");
            //add To List using for query add into Database
            pictureOption.Add(ptcImageContent);
            //Add to Panel
            panel.Controls.Add(ptcImageContent);
            return ptcImageContent;
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            BunifuImageButton btn = sender as BunifuImageButton;

            string fileName = openFolder();
            int index = btnOpenFolder.FindIndex(data => data == btn);
            if (!fileName.Equals(""))
            {
                pictureOption[index].Image = Image.FromFile(fileName);
                fileNames[index] = fileName;
            }
        }
        public Panel addPanel(int LocationY)
        {
            Panel panelTop = new Panel();

            addLabelOptions(panelTop);
            addCorrect(panelTop);

            addTextBoxOption(panelTop);

            addButtonOpenFolder(panelTop);
            addPictureBox(panelTop);

            panelTop.Dock = DockStyle.Top;
            panelTop.Size = new System.Drawing.Size(630, 89);
            panelTop.Location = new System.Drawing.Point(0, LocationY);

            panelOption.Add(panelTop);
            return panelTop;
        }
        public string openFolder()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please Choose Images";
            ofd.Filter = "Images File|*.png;*.jpg";
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                return ofd.FileName;
            }
            return "";
        }
    }
}
