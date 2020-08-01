using System.Windows.Forms;

namespace QuizApp
{
    partial class ChangeUser
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtLive = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPhoneNum = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFullName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRqPw = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.animation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnOpenFd = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSaved = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ptcUser = new System.Windows.Forms.PictureBox();
            this.btnHideShow = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelShow = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.viewUser = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFind = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHideShow)).BeginInit();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewUser)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelShow);
            this.animation.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 575);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.btnOpenFd);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnSaved);
            this.panel4.Controls.Add(this.txtDate);
            this.panel4.Controls.Add(this.ptcUser);
            this.panel4.Controls.Add(this.txtLive);
            this.panel4.Controls.Add(this.txtPhoneNum);
            this.panel4.Controls.Add(this.txtAge);
            this.panel4.Controls.Add(this.txtFullName);
            this.panel4.Controls.Add(this.txtRqPw);
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Controls.Add(this.bunifuCustomLabel9);
            this.panel4.Controls.Add(this.bunifuCustomLabel8);
            this.panel4.Controls.Add(this.bunifuCustomLabel7);
            this.panel4.Controls.Add(this.txtUsername);
            this.panel4.Controls.Add(this.bunifuCustomLabel6);
            this.panel4.Controls.Add(this.bunifuCustomLabel5);
            this.panel4.Controls.Add(this.bunifuCustomLabel3);
            this.panel4.Controls.Add(this.bunifuCustomLabel2);
            this.panel4.Controls.Add(this.bunifuCustomLabel1);
            this.animation.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 575);
            this.panel4.TabIndex = 17;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.txtDate.BorderRadius = 0;
            this.animation.SetDecoration(this.txtDate, BunifuAnimatorNS.DecorationType.None);
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtDate.FormatCustom = null;
            this.txtDate.Location = new System.Drawing.Point(167, 483);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(303, 36);
            this.txtDate.TabIndex = 27;
            this.txtDate.Value = new System.DateTime(2020, 7, 21, 9, 33, 39, 802);
            // 
            // txtLive
            // 
            this.txtLive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.txtLive, BunifuAnimatorNS.DecorationType.None);
            this.txtLive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLive.ForeColor = System.Drawing.Color.White;
            this.txtLive.HintForeColor = System.Drawing.Color.Empty;
            this.txtLive.HintText = "";
            this.txtLive.isPassword = false;
            this.txtLive.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.txtLive.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLive.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtLive.LineThickness = 4;
            this.txtLive.Location = new System.Drawing.Point(167, 421);
            this.txtLive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLive.Name = "txtLive";
            this.txtLive.Size = new System.Drawing.Size(396, 54);
            this.txtLive.TabIndex = 22;
            this.txtLive.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.txtPhoneNum, BunifuAnimatorNS.DecorationType.None);
            this.txtPhoneNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.ForeColor = System.Drawing.Color.White;
            this.txtPhoneNum.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhoneNum.HintText = "";
            this.txtPhoneNum.isPassword = false;
            this.txtPhoneNum.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.txtPhoneNum.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPhoneNum.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtPhoneNum.LineThickness = 4;
            this.txtPhoneNum.Location = new System.Drawing.Point(168, 535);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(396, 54);
            this.txtPhoneNum.TabIndex = 22;
            this.txtPhoneNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAge
            // 
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.txtAge, BunifuAnimatorNS.DecorationType.None);
            this.txtAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.White;
            this.txtAge.HintForeColor = System.Drawing.Color.Empty;
            this.txtAge.HintText = "";
            this.txtAge.isPassword = false;
            this.txtAge.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.txtAge.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAge.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtAge.LineThickness = 4;
            this.txtAge.Location = new System.Drawing.Point(167, 347);
            this.txtAge.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(396, 54);
            this.txtAge.TabIndex = 22;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFullName
            // 
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.txtFullName, BunifuAnimatorNS.DecorationType.None);
            this.txtFullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.HintForeColor = System.Drawing.Color.Empty;
            this.txtFullName.HintText = "";
            this.txtFullName.isPassword = false;
            this.txtFullName.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.txtFullName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFullName.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtFullName.LineThickness = 4;
            this.txtFullName.Location = new System.Drawing.Point(167, 283);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(396, 54);
            this.txtFullName.TabIndex = 22;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRqPw
            // 
            this.txtRqPw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animation.SetDecoration(this.txtRqPw, BunifuAnimatorNS.DecorationType.None);
            this.txtRqPw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRqPw.ForeColor = System.Drawing.Color.White;
            this.txtRqPw.HintForeColor = System.Drawing.Color.Empty;
            this.txtRqPw.HintText = "";
            this.txtRqPw.isPassword = true;
            this.txtRqPw.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.txtRqPw.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRqPw.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtRqPw.LineThickness = 4;
            this.txtRqPw.Location = new System.Drawing.Point(167, 214);
            this.txtRqPw.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRqPw.Name = "txtRqPw";
            this.txtRqPw.Size = new System.Drawing.Size(396, 54);
            this.txtRqPw.TabIndex = 22;
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
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.LineThickness = 4;
            this.txtPassword.Location = new System.Drawing.Point(167, 150);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(396, 54);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel9
            // 
            this.animation.SetDecoration(this.bunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(33, 437);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(102, 44);
            this.bunifuCustomLabel9.TabIndex = 17;
            this.bunifuCustomLabel9.Text = "Phone Number :";
            // 
            // bunifuCustomLabel8
            // 
            this.animation.SetDecoration(this.bunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(34, 483);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(102, 44);
            this.bunifuCustomLabel8.TabIndex = 17;
            this.bunifuCustomLabel8.Text = "Date of Birth :";
            // 
            // bunifuCustomLabel7
            // 
            this.animation.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(34, 551);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(102, 44);
            this.bunifuCustomLabel7.TabIndex = 17;
            this.bunifuCustomLabel7.Text = "Phone Number :";
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
            this.txtUsername.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.txtUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtUsername.LineThickness = 4;
            this.txtUsername.Location = new System.Drawing.Point(167, 86);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(396, 54);
            this.txtUsername.TabIndex = 24;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.animation.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(33, 363);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(102, 44);
            this.bunifuCustomLabel6.TabIndex = 17;
            this.bunifuCustomLabel6.Text = "Age  :";
            // 
            // bunifuCustomLabel5
            // 
            this.animation.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(33, 299);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(102, 44);
            this.bunifuCustomLabel5.TabIndex = 17;
            this.bunifuCustomLabel5.Text = "Full Name :";
            // 
            // bunifuCustomLabel3
            // 
            this.animation.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(33, 230);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(89, 44);
            this.bunifuCustomLabel3.TabIndex = 17;
            this.bunifuCustomLabel3.Text = "Request Password :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.animation.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(33, 176);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(82, 20);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "Password:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.animation.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 112);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(89, 20);
            this.bunifuCustomLabel1.TabIndex = 20;
            this.bunifuCustomLabel1.Text = "Username:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnHideShow);
            this.animation.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(650, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 575);
            this.panel2.TabIndex = 15;
            // 
            // animation
            // 
            this.animation.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.animation.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 1F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.animation.DefaultAnimation = animation3;
            // 
            // btnOpenFd
            // 
            this.btnOpenFd.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.btnOpenFd, BunifuAnimatorNS.DecorationType.None);
            this.btnOpenFd.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFd.Image")));
            this.btnOpenFd.ImageActive = null;
            this.btnOpenFd.Location = new System.Drawing.Point(355, 37);
            this.btnOpenFd.Name = "btnOpenFd";
            this.btnOpenFd.Size = new System.Drawing.Size(53, 41);
            this.btnOpenFd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOpenFd.TabIndex = 29;
            this.btnOpenFd.TabStop = false;
            this.btnOpenFd.Zoom = 10;
            this.btnOpenFd.Click += new System.EventHandler(this.btnOpenFd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.animation.SetDecoration(this.btnDelete, BunifuAnimatorNS.DecorationType.None);
            this.btnDelete.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnDelete.HoverState.ImageRotate = 5F;
            this.btnDelete.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageRotate = 0F;
            this.btnDelete.Location = new System.Drawing.Point(546, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnDelete.PressedState.ImageRotate = 10F;
            this.btnDelete.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.PressedState.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(64, 56);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // btnSaved
            // 
            this.btnSaved.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSaved.CheckedState.Parent = this.btnSaved;
            this.animation.SetDecoration(this.btnSaved, BunifuAnimatorNS.DecorationType.None);
            this.btnSaved.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnSaved.HoverState.ImageRotate = 5F;
            this.btnSaved.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSaved.HoverState.Parent = this.btnSaved;
            this.btnSaved.Image = ((System.Drawing.Image)(resources.GetObject("btnSaved.Image")));
            this.btnSaved.ImageRotate = 0F;
            this.btnSaved.Location = new System.Drawing.Point(546, 13);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnSaved.PressedState.ImageRotate = 10F;
            this.btnSaved.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSaved.PressedState.Parent = this.btnSaved;
            this.btnSaved.Size = new System.Drawing.Size(64, 56);
            this.btnSaved.TabIndex = 28;
            this.btnSaved.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // ptcUser
            // 
            this.ptcUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animation.SetDecoration(this.ptcUser, BunifuAnimatorNS.DecorationType.None);
            this.ptcUser.Location = new System.Drawing.Point(285, 14);
            this.ptcUser.Name = "ptcUser";
            this.ptcUser.Size = new System.Drawing.Size(64, 64);
            this.ptcUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcUser.TabIndex = 26;
            this.ptcUser.TabStop = false;
            // 
            // btnHideShow
            // 
            this.btnHideShow.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.btnHideShow, BunifuAnimatorNS.DecorationType.None);
            this.btnHideShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHideShow.Image = global::QuizApp.Properties.Resources.Next;
            this.btnHideShow.ImageActive = null;
            this.btnHideShow.Location = new System.Drawing.Point(0, 0);
            this.btnHideShow.Name = "btnHideShow";
            this.btnHideShow.Size = new System.Drawing.Size(29, 575);
            this.btnHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHideShow.TabIndex = 13;
            this.btnHideShow.TabStop = false;
            this.btnHideShow.Zoom = 10;
            this.btnHideShow.Click += new System.EventHandler(this.btnHideShow_Click);
            // 
            // panelShow
            // 
            this.panelShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelShow.BackgroundImage")));
            this.panelShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShow.Controls.Add(this.viewUser);
            this.panelShow.Controls.Add(this.panel3);
            this.animation.SetDecoration(this.panelShow, BunifuAnimatorNS.DecorationType.None);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panelShow.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(60)))));
            this.panelShow.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panelShow.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Quality = 10;
            this.panelShow.Size = new System.Drawing.Size(679, 575);
            this.panelShow.TabIndex = 14;
            // 
            // viewUser
            // 
            this.viewUser.AllowUserToAddRows = false;
            this.viewUser.AllowUserToDeleteRows = false;
            this.viewUser.AllowUserToResizeColumns = false;
            this.viewUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.viewUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.viewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.viewUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.viewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animation.SetDecoration(this.viewUser, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewUser.DefaultCellStyle = dataGridViewCellStyle11;
            this.viewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewUser.DoubleBuffered = true;
            this.viewUser.EnableHeadersVisualStyles = false;
            this.viewUser.GridColor = System.Drawing.Color.White;
            this.viewUser.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.viewUser.HeaderForeColor = System.Drawing.Color.Black;
            this.viewUser.Location = new System.Drawing.Point(0, 100);
            this.viewUser.Name = "viewUser";
            this.viewUser.ReadOnly = true;
            this.viewUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.viewUser.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.viewUser.ShowEditingIcon = false;
            this.viewUser.Size = new System.Drawing.Size(679, 475);
            this.viewUser.TabIndex = 6;
            this.viewUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewUser_CellDoubleClick);
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
            this.panel3.Size = new System.Drawing.Size(679, 100);
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
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 90;
            this.bunifuElipse1.TargetControl = this.ptcUser;
            // 
            // ChangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel1);
            this.animation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "ChangeUser";
            this.Size = new System.Drawing.Size(679, 575);
            this.Load += new System.EventHandler(this.ChangeUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHideShow)).EndInit();
            this.panelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewUser)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel panelShow;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuTextbox txtFind;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuImageButton btnHideShow;
        private BunifuAnimatorNS.BunifuTransition animation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox ptcUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRqPw;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnSaved;
        private Bunifu.Framework.UI.BunifuDatepicker txtDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhoneNum;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAge;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFullName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Guna.UI2.WinForms.Guna2ImageButton btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton btnOpenFd;
        private Bunifu.Framework.UI.BunifuCustomDataGrid viewUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLive;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
