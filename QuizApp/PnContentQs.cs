using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using Guna.UI2.WinForms;
using QuizApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    class PnContentQs
    {
        List<BunifuMaterialTextbox> txtContents = new List<BunifuMaterialTextbox>();
        List<Guna2ImageButton> btnOpens = new List<Guna2ImageButton>();
        List<PictureBox> ptcContents = new List<PictureBox>();
        List<BunifuThinButton2> btnClipboards = new List<BunifuThinButton2>();
        List<Panel> panels = new List<Panel>();
        List<Guna2ToggleSwitch> swTextPics = new List<Guna2ToggleSwitch>();
        List<Label> lblTextPics = new List<Label>();
        List<BunifuCheckbox> ckCorrects = new List<BunifuCheckbox>();
        List<string> fileNames = new List<string>();
        List<Options> options = new List<Options>();
        ZoomImg zoomImg;
        BunifuTransition animation;
        Panel panelRoot;
        int HeightLocationIndex=0;
        int currentPanel = 0;
        public PnContentQs(Panel panelRoot, BunifuTransition animation,ZoomImg zoomImg)
        {
            this.panelRoot = panelRoot;
            this.animation = animation;
            this.zoomImg = zoomImg;
        }
        private PictureBox addPtcBox()
        {
            PictureBox ptcContent = new PictureBox();
            ptcContent.BackColor = System.Drawing.Color.Transparent;
            animation.SetDecoration(ptcContent, BunifuAnimatorNS.DecorationType.None);
            ptcContent.Location = new System.Drawing.Point(196, 4);
            ptcContent.Size = new System.Drawing.Size(172, 91);
            ptcContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ptcContent.TabStop = false;
            ptcContent.MouseHover += new System.EventHandler(this.ptcQs_MouseHover);

            ptcContents.Add(ptcContent);

            return ptcContent;
        }
        private Guna2ImageButton addBtnOpen()
        {
            Guna2ImageButton btnOpen = new Guna2ImageButton();
            btnOpen.BackColor = System.Drawing.Color.Transparent;
            btnOpen.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            btnOpen.CheckedState.Parent = btnOpen;
            animation.SetDecoration(btnOpen, BunifuAnimatorNS.DecorationType.None);
            btnOpen.HoverState.ImageRotate = 15F;
            btnOpen.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            btnOpen.HoverState.Parent = btnOpen;
            //btnOpen.Image = ((System.Drawing.Image)(Resources.GetObject("btnOpen.Image")));
            btnOpen.ImageRotate = 0F;
            btnOpen.Location = new System.Drawing.Point(466, 11);
            btnOpen.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            btnOpen.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            btnOpen.PressedState.Parent = btnOpen;
            btnOpen.Size = new System.Drawing.Size(80, 65);
            btnOpen.Click += new System.EventHandler(this.btnOpen_Click);

            btnOpens.Add(btnOpen);
            return btnOpen;
        }
        private BunifuThinButton2 addBtnClipBoadrd()
        {
            BunifuThinButton2 btnClipboard = new BunifuThinButton2();
            btnClipboards.Add(btnClipboard);
            btnClipboard.ActiveBorderThickness = 1;
            btnClipboard.ActiveCornerRadius = 20;
            btnClipboard.ActiveFillColor = System.Drawing.Color.SeaGreen;
            btnClipboard.ActiveForecolor = System.Drawing.Color.White;
            btnClipboard.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            btnClipboard.BackColor = System.Drawing.Color.Transparent;
            btnClipboard.ButtonText = "Paste in Clipbard";
            btnClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            animation.SetDecoration(btnClipboard, BunifuAnimatorNS.DecorationType.None);
            btnClipboard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnClipboard.ForeColor = System.Drawing.Color.SeaGreen;
            btnClipboard.IdleBorderThickness = 1;
            btnClipboard.IdleCornerRadius = 20;
            btnClipboard.IdleFillColor = System.Drawing.Color.White;
            btnClipboard.IdleForecolor = System.Drawing.Color.SeaGreen;
            btnClipboard.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            btnClipboard.Location = new System.Drawing.Point(365, 19);
            btnClipboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnClipboard.Size = new System.Drawing.Size(96, 51);
            btnClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);

            return btnClipboard;
        }
        //private 
        private BunifuMaterialTextbox addTxtContent()
        {
            BunifuMaterialTextbox txtContent = new BunifuMaterialTextbox();
            txtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            animation.SetDecoration(txtContent, BunifuAnimatorNS.DecorationType.None);
            txtContent.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtContent.ForeColor = System.Drawing.SystemColors.Control;
            txtContent.HintForeColor = System.Drawing.Color.AliceBlue;
            txtContent.HintText = "Input Option";
            txtContent.isPassword = false;
            txtContent.LineFocusedColor = System.Drawing.Color.Gainsboro;
            txtContent.LineIdleColor =  System.Drawing.Color.SlateGray;
            txtContent.LineMouseHoverColor = System.Drawing.Color.Gainsboro;
            txtContent.LineThickness = 4;
            txtContent.Location = new System.Drawing.Point(59, 10);
            txtContent.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            txtContent.Name = "txtContent";
            txtContent.Size = new System.Drawing.Size(487, 85);
            txtContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            txtContents.Add(txtContent);
            return txtContent;
        }
        private Label addLblTextPic()
        {
            Label lblTextPic = new Label();
            animation.SetDecoration(lblTextPic, BunifuAnimatorNS.DecorationType.None);
            lblTextPic.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTextPic.ForeColor = System.Drawing.Color.Tan;
            lblTextPic.Location = new System.Drawing.Point(591, 35);
            lblTextPic.Size = new System.Drawing.Size(48, 34);
            lblTextPic.Text = "Texts";
            lblTextPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            lblTextPics.Add(lblTextPic);
            return lblTextPic;
        }
        private Guna2ToggleSwitch addSwTextPic()
        {
            Guna2ToggleSwitch swTextPic = new Guna2ToggleSwitch();
            swTextPics.Add(swTextPic);

            swTextPic.Checked = true;
            swTextPic.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            swTextPic.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            swTextPic.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            swTextPic.CheckedState.InnerColor = System.Drawing.Color.White;
            swTextPic.CheckedState.Parent = swTextPic;
            animation.SetDecoration(swTextPic, BunifuAnimatorNS.DecorationType.None);
            swTextPic.Location = new System.Drawing.Point(551, 39);
            swTextPic.ShadowDecoration.Parent = swTextPic;
            swTextPic.Size = new System.Drawing.Size(35, 20);
            swTextPic.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            swTextPic.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            swTextPic.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            swTextPic.UncheckedState.InnerColor = System.Drawing.Color.White;
            swTextPic.UncheckedState.Parent = swTextPic;
            swTextPic.CheckedChanged += new System.EventHandler(this.swTextPic_CheckedChanged);
            swTextPic_CheckedChanged(swTextPic, null);

            return swTextPic;
        }
        private BunifuCheckbox addCkCorrect()
        {
            BunifuCheckbox ckCorrect = new BunifuCheckbox();
            ckCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            ckCorrect.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            ckCorrect.Checked = false;
            ckCorrect.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            animation.SetDecoration(ckCorrect, BunifuAnimatorNS.DecorationType.None);
            ckCorrect.ForeColor = System.Drawing.Color.White;
            ckCorrect.Location = new System.Drawing.Point(16, 45);
            ckCorrect.Size = new System.Drawing.Size(20, 20);

            ckCorrects.Add(ckCorrect);
            return ckCorrect;
        }
        /*
         * Handle Func
         */
        private string getSwitch(int index)
        {
            return DataReader.getStringBitDb(!swTextPics[index].Checked);
        }
        private string getChecked(int index)
        {
            return DataReader.getStringBitDb(ckCorrects[index].Checked);
        }
        public void AddPanelQs()
        {
            AddPanelQs(currentPanel);
            ++currentPanel;
        }
        public void AddPanelQs(int index)
        {
            if (index >= panels.Count)
            {
                Panel pnOp = new Panel();
                pnOp.Controls.Add(addPtcBox());
                pnOp.Controls.Add(addBtnClipBoadrd());
                pnOp.Controls.Add(addBtnOpen());
                pnOp.Controls.Add(addTxtContent());
                pnOp.Controls.Add(addLblTextPic());
                pnOp.Controls.Add(addSwTextPic());
                pnOp.Controls.Add(addCkCorrect());
                fileNames.Add("");
                animation.SetDecoration(pnOp, BunifuAnimatorNS.DecorationType.None);
                pnOp.Dock = System.Windows.Forms.DockStyle.Top;
                pnOp.Location = new System.Drawing.Point(0, 100 * HeightLocationIndex);
                ++HeightLocationIndex;
                pnOp.Size = new System.Drawing.Size(696, 100);

                panels.Add(pnOp);
                panelRoot.Controls.Add(pnOp);
                panelRoot.Controls.SetChildIndex(pnOp, 1);
            }
            else panels[index].Visible = true;
        }
        public void HideLastPanel()
        {
            //foreach( var dt in panels.AsEnumerable<Panel>().Reverse<Panel>())
            //    if (dt.Visible) dt.Visible = false;
            for(int i=panels.Count-1;i>=0;--i)
                if (panels[i].Visible) { 
                    panels[i].Visible = false;
                    txtContents[i].Text = "";
                    fileNames[i]="" ;
                    break; }
            --currentPanel;
        }
        public void Clear()
        {
            for(int i=0;i<panels.Count;++i)
            {
                panels[i].Visible = false;
                txtContents[i].Text = "";
                ptcContents[i].Image = null;
            }
        }
        /*
         * Get Contents Option
         */
        private void setContentsOptions(int index,Options option)
        {
            swTextPics[index].Checked = !DataReader.getBooleanInStringBit(option.isImages);
            ckCorrects[index].Checked = DataReader.getBooleanInStringBit(option.isCorrect);
            setContent(index, option.Contents);
        }
        private void setContent(int index,string content)
        {
            if (swTextPics[index].Checked) txtContents[index].Text = content;
            else
            {
                fileNames[index] = content;
                ptcContents[index].Image = Image.FromFile(fileNames[index]);
            }
        }
        private string getContent(int index)
        {
            if (swTextPics[index].Checked) return txtContents[index].Text;
            return fileNames[index];
        }
        
        public bool getCountOpValid()
        {
            bool isContent = false,ckCr=false;
            for (int index = 0; index < panels.Count; ++index)
                if (!getContent(index).Equals(""))
                {
                    isContent = true;
                    if (ckCorrects[index].Checked)
                        ckCr = true;
                }
            if (!isContent) { MessBox.Warning("Please fill in at least one option");return false;}
            if (!ckCr) { MessBox.Warning("Check at least one correct answer");return false; }
            return true;
        }
        public List<Options> GetOption()
        {
            List<Options> options = new List<Options>();
            for(int index =0;index < panels.Count;++index)
            {
                string contentOp = getContent(index);
                if (contentOp.Equals("")) continue;
                Options option = new Options(contentOp, getSwitch(index),getChecked(index));
                options.Add(option);
            }
            return options;
        }
        public List<Options> GetOptionSave()
        {
            int indexOp = 0;
            for(int i=0;i<panels.Count && panels[i].Visible ==true;++i)
            {
                string contentOp = getContent(i);
                if (contentOp.Equals("")) continue;
                if (indexOp >= options.Count)
                {
                    options.Add(new Options(contentOp, getSwitch(i), getChecked(i)));
                }
                else
                {
                    options[indexOp].Contents = contentOp;
                    options[indexOp].isImages = getSwitch(i);
                    options[indexOp].isCorrect = getChecked(i);
                }
                ++indexOp;
            }
            while(indexOp<options.Count)
            {
                options[indexOp].DeleteOption();
                options.RemoveAt(indexOp);++indexOp;
            }
            return options;
        }
        public void SetOption(List<Options> options)
        {
            
            currentPanel = options.Count;
            for(int index =0;index < options.Count;++index)
            {
                AddPanelQs(index);
                setContentsOptions(index, options[index]);
            }
            this.options = options;
        }
        /*
         * Handle in Events
         */
        private void visibleText(BunifuMaterialTextbox txt, PictureBox ptc, Guna2ImageButton btn,BunifuThinButton2 btnClb, bool isText)
        {
            txt.Visible = isText;
            ptc.Visible = !isText;
            btn.Visible = !isText;
            btnClb.Visible = !isText;
        }
        public static void CreateFolder()
        {
            string root = Directory.GetCurrentDirectory() + "\\Images";
            if (!Directory.Exists(root))
                Directory.CreateDirectory(root);
        }
        public static string getFileImageDirectory()
        {
            return Directory.GetCurrentDirectory() + "\\Images\\" + DateTime.Now.ToString().Replace(" ", "").Replace("/", "_").Replace(":", "_");
        }
        public static string OpenFileDialog()
        { 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please Choose Images";
            ofd.Filter = "Images File|*.png;*.jpg";
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string nameFile = ofd.SafeFileName;
                string tailNameFile = nameFile.Substring(nameFile.Length - 4);
                CreateFolder();
                string fileName =  getFileImageDirectory()+ tailNameFile;
                File.Copy(ofd.FileName,fileName,true);
                return fileName;
            }
            return "";
        }
        public static string handleBtnClipboadClick(PictureBox ptc)
        {
            CreateFolder();
            string directory = getFileImageDirectory() + ".png";
            ptc.Image = Clipboard.GetImage();
            if(ptc.Image != null)
            {
                ptc.Image.Save(directory);
                return directory;
            }return "";
            

        }
        public void ZoomImages(PictureBox ptc)
        {
            zoomImg.SetImage(ptc);
        }
        /*
         * Event
         */
        private void btnOpen_Click(object sender, EventArgs e)
        {
                string fileName = OpenFileDialog();
                int index = btnOpens.FindIndex(x => x.Equals(sender));
                if (!fileName.Equals(""))
                {
                    ptcContents[index].Image = Image.FromFile(fileName);
                    fileNames[index] = fileName;
                }
        }
        private void btnClipboard_Click(object sender, EventArgs e)
        {
            int index = btnClipboards.FindIndex(x => x.Equals(sender));
            fileNames[index] = handleBtnClipboadClick(ptcContents[index]);
        }
        private void swTextPic_CheckedChanged(object sender, EventArgs e)
        {
            Guna2ToggleSwitch sw = sender as Guna2ToggleSwitch;
            int indexSelect = swTextPics.FindIndex(x => x == sw);
            lblTextPics[indexSelect].Text = sw.Checked ? "Texts" : "Images";
            visibleText(txtContents[indexSelect], ptcContents[indexSelect], btnOpens[indexSelect],btnClipboards[indexSelect],sw.Checked);
        }
        private void ptcQs_MouseHover(object sender, EventArgs e)
        {
            this.ZoomImages(sender as PictureBox);
        }

    }
}
