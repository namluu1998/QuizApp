namespace QuizApp
{
    partial class StartForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.Eclipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnRoot = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptcQs = new System.Windows.Forms.PictureBox();
            this.btnBack = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnNext = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblTitle = new System.Windows.Forms.RichTextBox();
            this.panelRootOption = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnBackMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSubmit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTimes = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.zoomImg1 = new QuizApp.ZoomImg();
            this.animation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnRoot.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcQs)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Eclipse
            // 
            this.Eclipse.ElipseRadius = 40;
            this.Eclipse.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnRoot
            // 
            this.pnRoot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnRoot.BackgroundImage")));
            this.pnRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnRoot.Controls.Add(this.panel1);
            this.pnRoot.Controls.Add(this.zoomImg1);
            this.animation.SetDecoration(this.pnRoot, BunifuAnimatorNS.DecorationType.None);
            this.pnRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRoot.GradientBottomLeft = System.Drawing.Color.SlateGray;
            this.pnRoot.GradientBottomRight = System.Drawing.Color.SteelBlue;
            this.pnRoot.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(168)))), ((int)(((byte)(196)))));
            this.pnRoot.GradientTopRight = System.Drawing.Color.LightSlateGray;
            this.pnRoot.Location = new System.Drawing.Point(0, 0);
            this.pnRoot.Name = "pnRoot";
            this.pnRoot.Quality = 10;
            this.pnRoot.Size = new System.Drawing.Size(626, 858);
            this.pnRoot.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ptcQs);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.panelRootOption);
            this.panel1.Controls.Add(this.bunifuGradientPanel2);
            this.animation.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 858);
            this.panel1.TabIndex = 42;
            // 
            // ptcQs
            // 
            this.ptcQs.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.ptcQs, BunifuAnimatorNS.DecorationType.None);
            this.ptcQs.Location = new System.Drawing.Point(184, 59);
            this.ptcQs.Name = "ptcQs";
            this.ptcQs.Size = new System.Drawing.Size(268, 146);
            this.ptcQs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcQs.TabIndex = 46;
            this.ptcQs.TabStop = false;
            this.ptcQs.MouseHover += new System.EventHandler(this.ptcQs_MouseHover);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.color = System.Drawing.Color.Transparent;
            this.btnBack.colorActive = System.Drawing.Color.LightSlateGray;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.btnBack, BunifuAnimatorNS.DecorationType.None);
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Navy;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImagePosition = 0;
            this.btnBack.ImageZoom = 50;
            this.btnBack.LabelPosition = 25;
            this.btnBack.LabelText = "Back";
            this.btnBack.Location = new System.Drawing.Point(0, 108);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 54);
            this.btnBack.TabIndex = 45;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.color = System.Drawing.Color.Transparent;
            this.btnNext.colorActive = System.Drawing.Color.LightSlateGray;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.btnNext, BunifuAnimatorNS.DecorationType.None);
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Navy;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImagePosition = 0;
            this.btnNext.ImageZoom = 50;
            this.btnNext.LabelPosition = 25;
            this.btnNext.LabelText = "Next";
            this.btnNext.Location = new System.Drawing.Point(563, 108);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 54);
            this.btnNext.TabIndex = 44;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SlateGray;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblTitle.EnableAutoDragDrop = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(66, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.ReadOnly = true;
            this.lblTitle.Size = new System.Drawing.Size(495, 146);
            this.lblTitle.TabIndex = 43;
            this.lblTitle.Text = "fsdafdqwdf\nqưd\nẫc\nsc\ncá\nc\n\ná\n\ndqaw";
            // 
            // panelRootOption
            // 
            this.panelRootOption.AutoScroll = true;
            this.panelRootOption.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.panelRootOption, BunifuAnimatorNS.DecorationType.None);
            this.panelRootOption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRootOption.Location = new System.Drawing.Point(0, 211);
            this.panelRootOption.Name = "panelRootOption";
            this.panelRootOption.Size = new System.Drawing.Size(626, 647);
            this.panelRootOption.TabIndex = 42;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel2.Controls.Add(this.btnBackMenu);
            this.bunifuGradientPanel2.Controls.Add(this.btnSubmit);
            this.bunifuGradientPanel2.Controls.Add(this.lblTimes);
            this.bunifuGradientPanel2.Controls.Add(this.lblIndex);
            this.animation.SetDecoration(this.bunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(55)))), ((int)(((byte)(42)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(626, 53);
            this.bunifuGradientPanel2.TabIndex = 41;
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.btnBackMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnBackMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBackMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnBackMenu.Image")));
            this.btnBackMenu.ImageActive = null;
            this.btnBackMenu.Location = new System.Drawing.Point(0, 0);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(45, 51);
            this.btnBackMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBackMenu.TabIndex = 43;
            this.btnBackMenu.TabStop = false;
            this.btnBackMenu.Zoom = 10;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Activecolor = System.Drawing.Color.LightCyan;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.BorderRadius = 0;
            this.btnSubmit.ButtonText = "Submit";
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.btnSubmit, BunifuAnimatorNS.DecorationType.None);
            this.btnSubmit.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmit.Iconimage = null;
            this.btnSubmit.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Iconimage_right")));
            this.btnSubmit.Iconimage_right_Selected = null;
            this.btnSubmit.Iconimage_Selected = null;
            this.btnSubmit.IconMarginLeft = 0;
            this.btnSubmit.IconMarginRight = 0;
            this.btnSubmit.IconRightVisible = true;
            this.btnSubmit.IconRightZoom = 0D;
            this.btnSubmit.IconVisible = true;
            this.btnSubmit.IconZoom = 90D;
            this.btnSubmit.IsTab = false;
            this.btnSubmit.Location = new System.Drawing.Point(517, 0);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSubmit.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnSubmit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSubmit.selected = false;
            this.btnSubmit.Size = new System.Drawing.Size(107, 51);
            this.btnSubmit.TabIndex = 42;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Textcolor = System.Drawing.Color.White;
            this.btnSubmit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTimes
            // 
            this.lblTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.lblTimes, BunifuAnimatorNS.DecorationType.None);
            this.lblTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimes.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimes.ForeColor = System.Drawing.Color.Sienna;
            this.lblTimes.Location = new System.Drawing.Point(305, 9);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(156, 43);
            this.lblTimes.TabIndex = 34;
            this.lblTimes.Text = "0";
            this.lblTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndex
            // 
            this.lblIndex.BackColor = System.Drawing.Color.Transparent;
            this.lblIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.lblIndex, BunifuAnimatorNS.DecorationType.None);
            this.lblIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIndex.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIndex.Location = new System.Drawing.Point(159, 9);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(99, 43);
            this.lblIndex.TabIndex = 35;
            this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zoomImg1
            // 
            this.zoomImg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.animation.SetDecoration(this.zoomImg1, BunifuAnimatorNS.DecorationType.None);
            this.zoomImg1.Location = new System.Drawing.Point(65, 250);
            this.zoomImg1.Name = "zoomImg1";
            this.zoomImg1.Size = new System.Drawing.Size(502, 399);
            this.zoomImg1.TabIndex = 0;
            this.zoomImg1.Visible = false;
            // 
            // animation
            // 
            this.animation.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.animation.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animation.DefaultAnimation = animation1;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 858);
            this.Controls.Add(this.pnRoot);
            this.animation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseDown);
            this.pnRoot.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcQs)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBackMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Eclipse;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnRoot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptcQs;
        private Bunifu.Framework.UI.BunifuTileButton btnBack;
        private Bunifu.Framework.UI.BunifuTileButton btnNext;
        private System.Windows.Forms.RichTextBox lblTitle;
        private System.Windows.Forms.Panel panelRootOption;
        private ZoomImg zoomImg1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuImageButton btnBackMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmit;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Label lblIndex;
        private BunifuAnimatorNS.BunifuTransition animation;
    }
}