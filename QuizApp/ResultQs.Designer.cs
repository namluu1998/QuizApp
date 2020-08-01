namespace QuizApp
{
    partial class ResultQs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultQs));
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnDetail = new System.Windows.Forms.Panel();
            this.lblResult = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ptcOp = new Bunifu.Framework.UI.BunifuImageButton();
            this.checkOp = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkResult = new Bunifu.Framework.UI.BunifuCheckbox();
            this.pnQs = new System.Windows.Forms.Panel();
            this.ptcQs = new System.Windows.Forms.PictureBox();
            this.lblDetail = new Bunifu.Framework.UI.BunifuImageButton();
            this.Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblQs = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblScore = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.percent = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.btnBackMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnContainOptions = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.animation = new Guna.UI2.WinForms.Guna2Transition();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcOp)).BeginInit();
            this.pnQs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcQs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackMenu)).BeginInit();
            this.pnContainOptions.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.animation.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(594, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 756);
            this.panel3.TabIndex = 5;
            // 
            // pnDetail
            // 
            this.pnDetail.BackgroundImage = global::QuizApp.Properties.Resources.Result;
            this.pnDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnDetail.Controls.Add(this.lblResult);
            this.pnDetail.Controls.Add(this.ptcOp);
            this.pnDetail.Controls.Add(this.checkOp);
            this.pnDetail.Controls.Add(this.checkResult);
            this.animation.SetDecoration(this.pnDetail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDetail.Location = new System.Drawing.Point(0, 160);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(558, 81);
            this.pnDetail.TabIndex = 2;
            this.pnDetail.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.lblResult, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(98, 1);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(304, 80);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptcOp
            // 
            this.ptcOp.BackColor = System.Drawing.Color.Transparent;
            this.ptcOp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animation.SetDecoration(this.ptcOp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ptcOp.Image = ((System.Drawing.Image)(resources.GetObject("ptcOp.Image")));
            this.ptcOp.ImageActive = null;
            this.ptcOp.Location = new System.Drawing.Point(163, 8);
            this.ptcOp.Name = "ptcOp";
            this.ptcOp.Size = new System.Drawing.Size(159, 70);
            this.ptcOp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcOp.TabIndex = 1;
            this.ptcOp.TabStop = false;
            this.ptcOp.Zoom = 10;
            this.ptcOp.MouseHover += new System.EventHandler(this.ptcOp_MouseHover);
            // 
            // checkOp
            // 
            this.checkOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkOp.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkOp.Checked = true;
            this.checkOp.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.animation.SetDecoration(this.checkOp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.checkOp.ForeColor = System.Drawing.Color.White;
            this.checkOp.Location = new System.Drawing.Point(472, 32);
            this.checkOp.Name = "checkOp";
            this.checkOp.Size = new System.Drawing.Size(20, 20);
            this.checkOp.TabIndex = 2;
            // 
            // checkResult
            // 
            this.checkResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkResult.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkResult.Checked = true;
            this.checkResult.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.animation.SetDecoration(this.checkResult, Guna.UI2.AnimatorNS.DecorationType.None);
            this.checkResult.ForeColor = System.Drawing.Color.White;
            this.checkResult.Location = new System.Drawing.Point(408, 32);
            this.checkResult.Name = "checkResult";
            this.checkResult.Size = new System.Drawing.Size(20, 20);
            this.checkResult.TabIndex = 1;
            // 
            // pnQs
            // 
            this.pnQs.BackColor = System.Drawing.Color.Transparent;
            this.pnQs.BackgroundImage = global::QuizApp.Properties.Resources.ResultQs;
            this.pnQs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnQs.Controls.Add(this.ptcQs);
            this.pnQs.Controls.Add(this.lblDetail);
            this.pnQs.Controls.Add(this.Check);
            this.pnQs.Controls.Add(this.lblQs);
            this.animation.SetDecoration(this.pnQs, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnQs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnQs.Location = new System.Drawing.Point(0, 0);
            this.pnQs.Name = "pnQs";
            this.pnQs.Size = new System.Drawing.Size(558, 113);
            this.pnQs.TabIndex = 1;
            // 
            // ptcQs
            // 
            this.animation.SetDecoration(this.ptcQs, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ptcQs.Location = new System.Drawing.Point(170, 18);
            this.ptcQs.Name = "ptcQs";
            this.ptcQs.Size = new System.Drawing.Size(162, 85);
            this.ptcQs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcQs.TabIndex = 0;
            this.ptcQs.TabStop = false;
            this.ptcQs.MouseHover += new System.EventHandler(this.ptcQs_MouseHover);
            // 
            // lblDetail
            // 
            this.lblDetail.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.lblDetail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblDetail.Image = global::QuizApp.Properties.Resources.chevron_down;
            this.lblDetail.ImageActive = null;
            this.lblDetail.Location = new System.Drawing.Point(488, 45);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(36, 35);
            this.lblDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblDetail.TabIndex = 2;
            this.lblDetail.TabStop = false;
            this.lblDetail.Zoom = 10;
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Check.Checked = true;
            this.Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.animation.SetDecoration(this.Check, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Check.ForeColor = System.Drawing.Color.White;
            this.Check.Location = new System.Drawing.Point(432, 56);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(20, 20);
            this.Check.TabIndex = 1;
            // 
            // lblQs
            // 
            this.animation.SetDecoration(this.lblQs, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblQs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQs.Location = new System.Drawing.Point(98, 14);
            this.lblQs.Name = "lblQs";
            this.lblQs.Size = new System.Drawing.Size(328, 96);
            this.lblQs.TabIndex = 0;
            this.lblQs.Text = "Question";
            this.lblQs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 756);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnBackMenu);
            this.animation.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 102);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblScore);
            this.panel5.Controls.Add(this.bunifuCustomLabel5);
            this.panel5.Controls.Add(this.percent);
            this.animation.SetDecoration(this.panel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(45, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(581, 102);
            this.panel5.TabIndex = 0;
            // 
            // lblScore
            // 
            this.animation.SetDecoration(this.lblScore, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblScore.Font = new System.Drawing.Font("UVF Slim Tony", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Sienna;
            this.lblScore.Location = new System.Drawing.Point(225, 38);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(88, 33);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "100";
            // 
            // bunifuCustomLabel5
            // 
            this.animation.SetDecoration(this.bunifuCustomLabel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("UVF Slim Tony", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Sienna;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(131, 38);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(88, 33);
            this.bunifuCustomLabel5.TabIndex = 0;
            this.bunifuCustomLabel5.Text = "Score : ";
            // 
            // percent
            // 
            this.percent.animated = true;
            this.percent.animationIterval = 2;
            this.percent.animationSpeed = 30;
            this.percent.BackColor = System.Drawing.Color.Transparent;
            this.percent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("percent.BackgroundImage")));
            this.percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animation.SetDecoration(this.percent, Guna.UI2.AnimatorNS.DecorationType.BottomMirror);
            this.percent.Dock = System.Windows.Forms.DockStyle.Right;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.ForeColor = System.Drawing.Color.Teal;
            this.percent.LabelVisible = true;
            this.percent.LineProgressThickness = 8;
            this.percent.LineThickness = 5;
            this.percent.Location = new System.Drawing.Point(481, 0);
            this.percent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.percent.MaxValue = 100;
            this.percent.Name = "percent";
            this.percent.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.percent.ProgressColor = System.Drawing.Color.Teal;
            this.percent.Size = new System.Drawing.Size(100, 100);
            this.percent.TabIndex = 0;
            this.percent.Value = 10;
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.btnBackMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBackMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBackMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnBackMenu.Image")));
            this.btnBackMenu.ImageActive = null;
            this.btnBackMenu.Location = new System.Drawing.Point(0, 0);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(45, 102);
            this.btnBackMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBackMenu.TabIndex = 44;
            this.btnBackMenu.TabStop = false;
            this.btnBackMenu.Zoom = 10;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.pnContent, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(36, 102);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(558, 756);
            this.pnContent.TabIndex = 6;
            // 
            // pnContainOptions
            // 
            this.pnContainOptions.Controls.Add(this.pnDetail);
            this.pnContainOptions.Controls.Add(this.panel4);
            this.pnContainOptions.Controls.Add(this.pnQs);
            this.animation.SetDecoration(this.pnContainOptions, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnContainOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainOptions.Location = new System.Drawing.Point(36, 102);
            this.pnContainOptions.Name = "pnContainOptions";
            this.pnContainOptions.Size = new System.Drawing.Size(558, 756);
            this.pnContainOptions.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuCustomLabel2);
            this.panel4.Controls.Add(this.bunifuCustomLabel3);
            this.panel4.Controls.Add(this.bunifuCustomLabel1);
            this.animation.SetDecoration(this.panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 47);
            this.panel4.TabIndex = 3;
            // 
            // bunifuCustomLabel2
            // 
            this.animation.SetDecoration(this.bunifuCustomLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("UVF Slim Tony", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(466, 3);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(72, 33);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Option";
            // 
            // bunifuCustomLabel3
            // 
            this.animation.SetDecoration(this.bunifuCustomLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("UVF Slim Tony", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(200, 3);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(81, 33);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "Content :";
            // 
            // bunifuCustomLabel1
            // 
            this.animation.SetDecoration(this.bunifuCustomLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("UVF Slim Tony", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(392, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(72, 33);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Correct";
            // 
            // animation
            // 
            this.animation.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.animation.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
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
            this.animation.MaxAnimationTime = 1000;
            // 
            // ResultQs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnContainOptions);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.animation.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "ResultQs";
            this.Size = new System.Drawing.Size(626, 858);
            this.Load += new System.EventHandler(this.ResultQs_Load);
            this.pnDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcOp)).EndInit();
            this.pnQs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcQs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBackMenu)).EndInit();
            this.pnContainOptions.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnDetail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblResult;
        private Bunifu.Framework.UI.BunifuImageButton ptcOp;
        private Bunifu.Framework.UI.BunifuCheckbox checkOp;
        private Bunifu.Framework.UI.BunifuCheckbox checkResult;
        private System.Windows.Forms.Panel pnQs;
        private Bunifu.Framework.UI.BunifuImageButton lblDetail;
        private Bunifu.Framework.UI.BunifuCheckbox Check;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.PictureBox ptcQs;
        private System.Windows.Forms.Panel pnContainOptions;
        private Guna.UI2.WinForms.Guna2Transition animation;
        private Bunifu.Framework.UI.BunifuImageButton btnBackMenu;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuCustomLabel lblScore;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCircleProgressbar percent;
        private System.Windows.Forms.Timer timer1;
    }
}
