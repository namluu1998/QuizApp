namespace QuizApp
{
    partial class AddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelShow = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.viewUser = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFind = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnHideShow = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtRqPw = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbxTypeUser = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.animation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewUser)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHideShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.panelShow);
            this.panel1.Controls.Add(this.btnHideShow);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.txtRqPw);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.cbxTypeUser);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.animation.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 575);
            this.panel1.TabIndex = 1;
            // 
            // panelShow
            // 
            this.panelShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelShow.BackgroundImage")));
            this.panelShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShow.Controls.Add(this.viewUser);
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
            this.panelShow.TabIndex = 11;
            this.panelShow.Visible = false;
            // 
            // viewUser
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewUser.BackgroundColor = System.Drawing.Color.Gray;
            this.viewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animation.SetDecoration(this.viewUser, BunifuAnimatorNS.DecorationType.None);
            this.viewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewUser.DoubleBuffered = true;
            this.viewUser.EnableHeadersVisualStyles = false;
            this.viewUser.HeaderBgColor = System.Drawing.Color.DarkSeaGreen;
            this.viewUser.HeaderForeColor = System.Drawing.Color.Black;
            this.viewUser.Location = new System.Drawing.Point(0, 100);
            this.viewUser.Name = "viewUser";
            this.viewUser.ReadOnly = true;
            this.viewUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.viewUser.Size = new System.Drawing.Size(649, 475);
            this.viewUser.TabIndex = 8;
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
            // btnHideShow
            // 
            this.btnHideShow.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.btnHideShow, BunifuAnimatorNS.DecorationType.None);
            this.btnHideShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHideShow.Image = global::QuizApp.Properties.Resources.Next;
            this.btnHideShow.ImageActive = null;
            this.btnHideShow.Location = new System.Drawing.Point(650, 0);
            this.btnHideShow.Name = "btnHideShow";
            this.btnHideShow.Size = new System.Drawing.Size(29, 575);
            this.btnHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHideShow.TabIndex = 8;
            this.btnHideShow.TabStop = false;
            this.btnHideShow.Zoom = 10;
            this.btnHideShow.Click += new System.EventHandler(this.btnHideShow_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.ActiveBorderThickness = 1;
            this.btnAddUser.ActiveCornerRadius = 20;
            this.btnAddUser.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnAddUser.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddUser.ActiveLineColor = System.Drawing.Color.Silver;
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.BackgroundImage")));
            this.btnAddUser.ButtonText = "Add User";
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animation.SetDecoration(this.btnAddUser, BunifuAnimatorNS.DecorationType.None);
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.Silver;
            this.btnAddUser.IdleBorderThickness = 1;
            this.btnAddUser.IdleCornerRadius = 20;
            this.btnAddUser.IdleFillColor = System.Drawing.Color.White;
            this.btnAddUser.IdleForecolor = System.Drawing.Color.Gray;
            this.btnAddUser.IdleLineColor = System.Drawing.Color.Gray;
            this.btnAddUser.Location = new System.Drawing.Point(215, 393);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(191, 54);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtRqPw
            // 
            this.txtRqPw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.txtRqPw, BunifuAnimatorNS.DecorationType.None);
            this.txtRqPw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRqPw.ForeColor = System.Drawing.Color.White;
            this.txtRqPw.HintForeColor = System.Drawing.Color.Empty;
            this.txtRqPw.HintText = "";
            this.txtRqPw.isPassword = false;
            this.txtRqPw.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtRqPw.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRqPw.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtRqPw.LineThickness = 4;
            this.txtRqPw.Location = new System.Drawing.Point(175, 259);
            this.txtRqPw.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRqPw.Name = "txtRqPw";
            this.txtRqPw.Size = new System.Drawing.Size(396, 54);
            this.txtRqPw.TabIndex = 2;
            this.txtRqPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.txtPassword, BunifuAnimatorNS.DecorationType.None);
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 4;
            this.txtPassword.Location = new System.Drawing.Point(175, 195);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(396, 54);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.txtUsername, BunifuAnimatorNS.DecorationType.None);
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUsername.LineThickness = 4;
            this.txtUsername.Location = new System.Drawing.Point(175, 131);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(396, 54);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbxTypeUser
            // 
            this.cbxTypeUser.BackColor = System.Drawing.Color.Transparent;
            this.cbxTypeUser.BorderRadius = 3;
            this.animation.SetDecoration(this.cbxTypeUser, BunifuAnimatorNS.DecorationType.None);
            this.cbxTypeUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTypeUser.ForeColor = System.Drawing.Color.White;
            this.cbxTypeUser.Items = new string[] {
        "Admin",
        "User"};
            this.cbxTypeUser.Location = new System.Drawing.Point(175, 81);
            this.cbxTypeUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbxTypeUser.Name = "cbxTypeUser";
            this.cbxTypeUser.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.cbxTypeUser.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.cbxTypeUser.selectedIndex = -1;
            this.cbxTypeUser.Size = new System.Drawing.Size(280, 46);
            this.cbxTypeUser.TabIndex = 1;
            // 
            // bunifuCustomLabel3
            // 
            this.animation.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(41, 275);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(89, 44);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "Request Password :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.animation.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(41, 221);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(82, 20);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Password:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.animation.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(41, 95);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(93, 20);
            this.bunifuCustomLabel4.TabIndex = 0;
            this.bunifuCustomLabel4.Text = "Type User :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.animation.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(41, 157);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(89, 20);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Username:";
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
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel1);
            this.animation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "AddUsers";
            this.Size = new System.Drawing.Size(679, 575);
            this.Load += new System.EventHandler(this.AddUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewUser)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHideShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRqPw;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuDropdown cbxTypeUser;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private BunifuAnimatorNS.BunifuTransition animation;
        private Bunifu.Framework.UI.BunifuImageButton btnHideShow;
        private Bunifu.Framework.UI.BunifuGradientPanel panelShow;
        private Bunifu.Framework.UI.BunifuCustomDataGrid viewUser;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuTextbox txtFind;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
    }
}
