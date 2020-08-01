using System.Windows.Forms;

namespace QuizApp
{
    partial class ChangeExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeExam));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelShow = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFind = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaved = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtExams = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnHideShow = new Bunifu.Framework.UI.BunifuImageButton();
            this.animation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.viewExams = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHideShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewExams)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.panelShow);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnSaved);
            this.panel1.Controls.Add(this.txtExams);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.animation.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 575);
            this.panel1.TabIndex = 6;
            // 
            // panelShow
            // 
            this.panelShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelShow.BackgroundImage")));
            this.panelShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShow.Controls.Add(this.viewExams);
            this.panelShow.Controls.Add(this.panel3);
            this.animation.SetDecoration(this.panelShow, BunifuAnimatorNS.DecorationType.None);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelShow.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panelShow.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(60)))));
            this.panelShow.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panelShow.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Quality = 10;
            this.panelShow.Size = new System.Drawing.Size(649, 575);
            this.panelShow.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtFind);
            this.panel3.Controls.Add(this.bunifuThinButton23);
            this.animation.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 100);
            this.panel3.TabIndex = 7;
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.Silver;
            this.txtFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFind.BackgroundImage")));
            this.txtFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animation.SetDecoration(this.txtFind, BunifuAnimatorNS.DecorationType.None);
            this.txtFind.ForeColor = System.Drawing.Color.White;
            this.txtFind.Icon = ((System.Drawing.Image)(resources.GetObject("txtFind.Icon")));
            this.txtFind.Location = new System.Drawing.Point(3, 23);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(491, 42);
            this.txtFind.TabIndex = 4;
            this.txtFind.text = "";
            this.txtFind.OnTextChange += new System.EventHandler(this.txtFind_OnTextChange);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Reset";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.bunifuThinButton23, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(502, 23);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(116, 41);
            this.bunifuThinButton23.TabIndex = 5;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDel
            // 
            this.btnDel.ActiveBorderThickness = 1;
            this.btnDel.ActiveCornerRadius = 20;
            this.btnDel.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDel.ActiveForecolor = System.Drawing.Color.White;
            this.btnDel.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.ButtonText = "Delete Exams";
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.btnDel, BunifuAnimatorNS.DecorationType.None);
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Teal;
            this.btnDel.IdleBorderThickness = 1;
            this.btnDel.IdleCornerRadius = 20;
            this.btnDel.IdleFillColor = System.Drawing.Color.White;
            this.btnDel.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.btnDel.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnDel.Location = new System.Drawing.Point(341, 313);
            this.btnDel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(199, 43);
            this.btnDel.TabIndex = 4;
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSaved
            // 
            this.btnSaved.ActiveBorderThickness = 1;
            this.btnSaved.ActiveCornerRadius = 20;
            this.btnSaved.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnSaved.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaved.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnSaved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnSaved.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaved.BackgroundImage")));
            this.btnSaved.ButtonText = "Save Changed";
            this.btnSaved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.btnSaved, BunifuAnimatorNS.DecorationType.None);
            this.btnSaved.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaved.ForeColor = System.Drawing.Color.Teal;
            this.btnSaved.IdleBorderThickness = 1;
            this.btnSaved.IdleCornerRadius = 20;
            this.btnSaved.IdleFillColor = System.Drawing.Color.White;
            this.btnSaved.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.btnSaved.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnSaved.Location = new System.Drawing.Point(108, 313);
            this.btnSaved.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(199, 43);
            this.btnSaved.TabIndex = 4;
            this.btnSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // txtExams
            // 
            this.txtExams.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.txtExams, BunifuAnimatorNS.DecorationType.None);
            this.txtExams.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtExams.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtExams.HintForeColor = System.Drawing.Color.AntiqueWhite;
            this.txtExams.HintText = "Exam Name";
            this.txtExams.isPassword = false;
            this.txtExams.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtExams.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtExams.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtExams.LineThickness = 3;
            this.txtExams.Location = new System.Drawing.Point(217, 150);
            this.txtExams.Margin = new System.Windows.Forms.Padding(4);
            this.txtExams.Name = "txtExams";
            this.txtExams.Size = new System.Drawing.Size(387, 61);
            this.txtExams.TabIndex = 2;
            this.txtExams.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.animation.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(58, 190);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(113, 21);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Exam Name :";
            // 
            // btnHideShow
            // 
            this.btnHideShow.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.btnHideShow, BunifuAnimatorNS.DecorationType.None);
            this.btnHideShow.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHideShow.Image = global::QuizApp.Properties.Resources.Next;
            this.btnHideShow.ImageActive = null;
            this.btnHideShow.Location = new System.Drawing.Point(649, 0);
            this.btnHideShow.Name = "btnHideShow";
            this.btnHideShow.Size = new System.Drawing.Size(29, 575);
            this.btnHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHideShow.TabIndex = 7;
            this.btnHideShow.TabStop = false;
            this.btnHideShow.Zoom = 10;
            this.btnHideShow.Click += new System.EventHandler(this.btnHideShow_Click);
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
            // viewExams
            // 
            this.viewExams.AllowUserToAddRows = false;
            this.viewExams.AllowUserToDeleteRows = false;
            this.viewExams.AllowUserToResizeColumns = false;
            this.viewExams.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewExams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewExams.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.viewExams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewExams.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.viewExams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animation.SetDecoration(this.viewExams, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewExams.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewExams.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewExams.DoubleBuffered = true;
            this.viewExams.EnableHeadersVisualStyles = false;
            this.viewExams.GridColor = System.Drawing.Color.White;
            this.viewExams.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.viewExams.HeaderForeColor = System.Drawing.Color.Black;
            this.viewExams.Location = new System.Drawing.Point(0, 100);
            this.viewExams.Name = "viewExams";
            this.viewExams.ReadOnly = true;
            this.viewExams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.viewExams.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.viewExams.ShowEditingIcon = false;
            this.viewExams.Size = new System.Drawing.Size(649, 475);
            this.viewExams.TabIndex = 7;
            // 
            // ChangeExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.btnHideShow);
            this.Controls.Add(this.panel1);
            this.animation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "ChangeExam";
            this.Size = new System.Drawing.Size(679, 575);
            this.Load += new System.EventHandler(this.ChangeExam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelShow.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHideShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaved;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtExams;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnHideShow;
        private Bunifu.Framework.UI.BunifuGradientPanel panelShow;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuTextbox txtFind;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private BunifuAnimatorNS.BunifuTransition animation;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid viewExams;
    }
}
