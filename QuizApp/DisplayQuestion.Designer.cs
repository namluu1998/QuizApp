using System.Windows.Forms;

namespace QuizApp
{
    partial class DisplayQuestion
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayQuestion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.animation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelContents = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClipboard = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ptcQs = new System.Windows.Forms.PictureBox();
            this.btnOpFd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.switchText = new Bunifu.Framework.UI.BunifuSwitch();
            this.lblDisplaySwitch = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.pnMenusQs = new System.Windows.Forms.Panel();
            this.GridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtFind = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaved = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDel = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtTitle = new System.Windows.Forms.RichTextBox();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHideShow = new Bunifu.Framework.UI.BunifuImageButton();
            this.eclipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cbxNameExams = new Bunifu.Framework.UI.BunifuDropdown();
            this.pnExplain = new System.Windows.Forms.Panel();
            this.rtxExplain = new System.Windows.Forms.RichTextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddOption = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelContents.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcQs)).BeginInit();
            this.PanelAdd.SuspendLayout();
            this.pnMenusQs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHideShow)).BeginInit();
            this.pnExplain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // animation
            // 
            this.animation.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.animation.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animation.DefaultAnimation = animation1;
            // 
            // panelContents
            // 
            this.panelContents.BackColor = System.Drawing.Color.Transparent;
            this.panelContents.Controls.Add(this.panel1);
            this.panelContents.Controls.Add(this.panel3);
            this.animation.SetDecoration(this.panelContents, BunifuAnimatorNS.DecorationType.None);
            this.panelContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContents.Location = new System.Drawing.Point(0, 0);
            this.panelContents.Name = "panelContents";
            this.panelContents.Size = new System.Drawing.Size(696, 556);
            this.panelContents.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pnMenusQs);
            this.panel1.Controls.Add(this.cbxNameExams);
            this.panel1.Controls.Add(this.btnClipboard);
            this.panel1.Controls.Add(this.ptcQs);
            this.panel1.Controls.Add(this.btnOpFd);
            this.panel1.Controls.Add(this.switchText);
            this.panel1.Controls.Add(this.lblDisplaySwitch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.PanelAdd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.kryptonBorderEdge1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.animation.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 556);
            this.panel1.TabIndex = 5;
            // 
            // btnClipboard
            // 
            this.btnClipboard.ActiveBorderThickness = 1;
            this.btnClipboard.ActiveCornerRadius = 20;
            this.btnClipboard.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClipboard.ActiveForecolor = System.Drawing.Color.White;
            this.btnClipboard.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnClipboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClipboard.BackgroundImage")));
            this.btnClipboard.ButtonText = "Paste in Clipbard";
            this.btnClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.btnClipboard, BunifuAnimatorNS.DecorationType.None);
            this.btnClipboard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClipboard.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClipboard.IdleBorderThickness = 1;
            this.btnClipboard.IdleCornerRadius = 20;
            this.btnClipboard.IdleFillColor = System.Drawing.Color.White;
            this.btnClipboard.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClipboard.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnClipboard.Location = new System.Drawing.Point(320, 68);
            this.btnClipboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(96, 51);
            this.btnClipboard.TabIndex = 82;
            this.btnClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // ptcQs
            // 
            this.ptcQs.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.ptcQs, BunifuAnimatorNS.DecorationType.None);
            this.ptcQs.Location = new System.Drawing.Point(141, 50);
            this.ptcQs.Name = "ptcQs";
            this.ptcQs.Size = new System.Drawing.Size(172, 91);
            this.ptcQs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcQs.TabIndex = 84;
            this.ptcQs.TabStop = false;
            this.ptcQs.MouseHover += new System.EventHandler(this.ptcQs_MouseHover);
            // 
            // btnOpFd
            // 
            this.btnOpFd.BackColor = System.Drawing.Color.Transparent;
            this.btnOpFd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnOpFd.CheckedState.Parent = this.btnOpFd;
            this.animation.SetDecoration(this.btnOpFd, BunifuAnimatorNS.DecorationType.None);
            this.btnOpFd.HoverState.ImageRotate = 15F;
            this.btnOpFd.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnOpFd.HoverState.Parent = this.btnOpFd;
            this.btnOpFd.Image = ((System.Drawing.Image)(resources.GetObject("btnOpFd.Image")));
            this.btnOpFd.ImageRotate = 0F;
            this.btnOpFd.Location = new System.Drawing.Point(435, 68);
            this.btnOpFd.Name = "btnOpFd";
            this.btnOpFd.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnOpFd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnOpFd.PressedState.Parent = this.btnOpFd;
            this.btnOpFd.Size = new System.Drawing.Size(80, 65);
            this.btnOpFd.TabIndex = 83;
            this.btnOpFd.Click += new System.EventHandler(this.btnOpFd_Click);
            // 
            // switchText
            // 
            this.switchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchText.BorderRadius = 0;
            this.switchText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.switchText, BunifuAnimatorNS.DecorationType.None);
            this.switchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchText.Location = new System.Drawing.Point(440, 18);
            this.switchText.Name = "switchText";
            this.switchText.Oncolor = System.Drawing.Color.SeaGreen;
            this.switchText.Onoffcolor = System.Drawing.Color.DarkGray;
            this.switchText.Size = new System.Drawing.Size(51, 19);
            this.switchText.TabIndex = 79;
            this.switchText.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.switchText.Value = true;
            this.switchText.Click += new System.EventHandler(this.switchText_Click);
            // 
            // lblDisplaySwitch
            // 
            this.lblDisplaySwitch.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.lblDisplaySwitch, BunifuAnimatorNS.DecorationType.None);
            this.lblDisplaySwitch.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplaySwitch.ForeColor = System.Drawing.Color.Tan;
            this.lblDisplaySwitch.Location = new System.Drawing.Point(475, 10);
            this.lblDisplaySwitch.Name = "lblDisplaySwitch";
            this.lblDisplaySwitch.Size = new System.Drawing.Size(100, 34);
            this.lblDisplaySwitch.TabIndex = 80;
            this.lblDisplaySwitch.Text = "Texts";
            this.lblDisplaySwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.animation.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("UVF Slim Tony", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(344, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 34);
            this.label7.TabIndex = 81;
            this.label7.Text = "is Text :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelAdd
            // 
            this.PanelAdd.AutoScroll = true;
            this.PanelAdd.Controls.Add(this.pnExplain);
            this.animation.SetDecoration(this.PanelAdd, BunifuAnimatorNS.DecorationType.None);
            this.PanelAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelAdd.Location = new System.Drawing.Point(0, 167);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(672, 389);
            this.PanelAdd.TabIndex = 77;
            this.PanelAdd.Visible = false;
            // 
            // pnMenusQs
            // 
            this.pnMenusQs.Controls.Add(this.GridView);
            this.pnMenusQs.Controls.Add(this.bunifuThinButton22);
            this.pnMenusQs.Controls.Add(this.txtFind);
            this.animation.SetDecoration(this.pnMenusQs, BunifuAnimatorNS.DecorationType.None);
            this.pnMenusQs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenusQs.Location = new System.Drawing.Point(0, 0);
            this.pnMenusQs.Name = "pnMenusQs";
            this.pnMenusQs.Size = new System.Drawing.Size(672, 167);
            this.pnMenusQs.TabIndex = 79;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animation.SetDecoration(this.GridView, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.DoubleBuffered = true;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.GridColor = System.Drawing.Color.White;
            this.GridView.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.GridView.HeaderForeColor = System.Drawing.Color.Black;
            this.GridView.Location = new System.Drawing.Point(0, -325);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.GridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridView.ShowEditingIcon = false;
            this.GridView.Size = new System.Drawing.Size(672, 492);
            this.GridView.TabIndex = 0;
            this.GridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellDoubleClick);
            this.GridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellMouseEnter);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Reset";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(512, 11);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(116, 41);
            this.bunifuThinButton22.TabIndex = 3;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.Silver;
            this.txtFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFind.BackgroundImage")));
            this.txtFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animation.SetDecoration(this.txtFind, BunifuAnimatorNS.DecorationType.None);
            this.txtFind.ForeColor = System.Drawing.Color.White;
            this.txtFind.Icon = ((System.Drawing.Image)(resources.GetObject("txtFind.Icon")));
            this.txtFind.Location = new System.Drawing.Point(0, 11);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(496, 42);
            this.txtFind.TabIndex = 1;
            this.txtFind.text = "";
            this.txtFind.OnTextChange += new System.EventHandler(this.txtFind_OnTextChange);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuImageButton2);
            this.panel2.Controls.Add(this.btnAddOption);
            this.panel2.Controls.Add(this.btnSaved);
            this.panel2.Controls.Add(this.btnDel);
            this.animation.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(614, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 160);
            this.panel2.TabIndex = 75;
            // 
            // btnSaved
            // 
            this.btnSaved.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.btnSaved, BunifuAnimatorNS.DecorationType.None);
            this.btnSaved.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaved.Image = ((System.Drawing.Image)(resources.GetObject("btnSaved.Image")));
            this.btnSaved.ImageActive = null;
            this.btnSaved.Location = new System.Drawing.Point(0, 0);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(52, 40);
            this.btnSaved.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSaved.TabIndex = 71;
            this.btnSaved.TabStop = false;
            this.btnSaved.Zoom = 10;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.btnDel, BunifuAnimatorNS.DecorationType.None);
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageActive = null;
            this.btnDel.Location = new System.Drawing.Point(0, 120);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(52, 40);
            this.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDel.TabIndex = 71;
            this.btnDel.TabStop = false;
            this.btnDel.Zoom = 10;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animation.SetDecoration(this.txtTitle, BunifuAnimatorNS.DecorationType.None);
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(81, 68);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(469, 73);
            this.txtTitle.TabIndex = 28;
            this.txtTitle.Text = "";
            // 
            // kryptonBorderEdge1
            // 
            this.animation.SetDecoration(this.kryptonBorderEdge1, BunifuAnimatorNS.DecorationType.None);
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(81, 147);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(481, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.animation.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(22, 95);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(53, 22);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Title :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btnHideShow);
            this.animation.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(672, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 556);
            this.panel3.TabIndex = 4;
            // 
            // btnHideShow
            // 
            this.btnHideShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.animation.SetDecoration(this.btnHideShow, BunifuAnimatorNS.DecorationType.None);
            this.btnHideShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHideShow.Image = global::QuizApp.Properties.Resources.Next;
            this.btnHideShow.ImageActive = null;
            this.btnHideShow.Location = new System.Drawing.Point(0, 0);
            this.btnHideShow.Name = "btnHideShow";
            this.btnHideShow.Size = new System.Drawing.Size(24, 556);
            this.btnHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHideShow.TabIndex = 2;
            this.btnHideShow.TabStop = false;
            this.btnHideShow.Zoom = 10;
            this.btnHideShow.Click += new System.EventHandler(this.btnHideShow_Click);
            // 
            // eclipse
            // 
            this.eclipse.ElipseRadius = 20;
            this.eclipse.TargetControl = this;
            // 
            // label6
            // 
            this.animation.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("UVF Slim Tony", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(-1, -5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 64);
            this.label6.TabIndex = 87;
            this.label6.Text = "Type Question";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxNameExams
            // 
            this.cbxNameExams.BackColor = System.Drawing.Color.Transparent;
            this.cbxNameExams.BorderRadius = 3;
            this.animation.SetDecoration(this.cbxNameExams, BunifuAnimatorNS.DecorationType.None);
            this.cbxNameExams.ForeColor = System.Drawing.Color.White;
            this.cbxNameExams.Items = new string[0];
            this.cbxNameExams.Location = new System.Drawing.Point(119, 9);
            this.cbxNameExams.Name = "cbxNameExams";
            this.cbxNameExams.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.cbxNameExams.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.cbxNameExams.selectedIndex = -1;
            this.cbxNameExams.Size = new System.Drawing.Size(237, 35);
            this.cbxNameExams.TabIndex = 86;
            // 
            // pnExplain
            // 
            this.pnExplain.Controls.Add(this.rtxExplain);
            this.pnExplain.Controls.Add(this.panel13);
            this.pnExplain.Controls.Add(this.label2);
            this.animation.SetDecoration(this.pnExplain, BunifuAnimatorNS.DecorationType.None);
            this.pnExplain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnExplain.Location = new System.Drawing.Point(0, 0);
            this.pnExplain.Name = "pnExplain";
            this.pnExplain.Size = new System.Drawing.Size(672, 106);
            this.pnExplain.TabIndex = 80;
            // 
            // rtxExplain
            // 
            this.rtxExplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.rtxExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animation.SetDecoration(this.rtxExplain, BunifuAnimatorNS.DecorationType.None);
            this.rtxExplain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxExplain.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtxExplain.Location = new System.Drawing.Point(134, 13);
            this.rtxExplain.Name = "rtxExplain";
            this.rtxExplain.Size = new System.Drawing.Size(428, 82);
            this.rtxExplain.TabIndex = 63;
            this.rtxExplain.Text = "";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.animation.SetDecoration(this.panel13, BunifuAnimatorNS.DecorationType.None);
            this.panel13.Location = new System.Drawing.Point(38, 98);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(528, 1);
            this.panel13.TabIndex = 66;
            // 
            // label2
            // 
            this.animation.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("UVF Slim Tony", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 79);
            this.label2.TabIndex = 65;
            this.label2.Text = "Explain";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddOption
            // 
            this.btnAddOption.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.btnAddOption, BunifuAnimatorNS.DecorationType.None);
            this.btnAddOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddOption.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOption.Image")));
            this.btnAddOption.ImageActive = null;
            this.btnAddOption.Location = new System.Drawing.Point(0, 40);
            this.btnAddOption.Name = "btnAddOption";
            this.btnAddOption.Size = new System.Drawing.Size(52, 40);
            this.btnAddOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddOption.TabIndex = 72;
            this.btnAddOption.TabStop = false;
            this.btnAddOption.Zoom = 10;
            this.btnAddOption.Click += new System.EventHandler(this.btnAddOption_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(0, 80);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(52, 40);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 74;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // DisplayQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panelContents);
            this.animation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "DisplayQuestion";
            this.Size = new System.Drawing.Size(696, 556);
            this.Load += new System.EventHandler(this.DisplayQuestion_Load);
            this.panelContents.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcQs)).EndInit();
            this.PanelAdd.ResumeLayout(false);
            this.pnMenusQs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSaved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDel)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHideShow)).EndInit();
            this.pnExplain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition animation;
        private System.Windows.Forms.Panel panelContents;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton btnHideShow;
        private Bunifu.Framework.UI.BunifuElipse eclipse;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnSaved;
        private Bunifu.Framework.UI.BunifuImageButton btnDel;
        private System.Windows.Forms.RichTextBox txtTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.Panel pnMenusQs;
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridView;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuTextbox txtFind;
        public Bunifu.Framework.UI.BunifuSwitch switchText;
        private Label lblDisplaySwitch;
        private Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClipboard;
        private PictureBox ptcQs;
        private Guna.UI2.WinForms.Guna2ImageButton btnOpFd;
        private Label label6;
        private Bunifu.Framework.UI.BunifuDropdown cbxNameExams;
        private Panel pnExplain;
        private RichTextBox rtxExplain;
        private Panel panel13;
        private Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnAddOption;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}
