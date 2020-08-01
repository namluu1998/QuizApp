namespace QuizApp
{
    partial class AdminForm
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnMove = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUserChange = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panelExams = new System.Windows.Forms.Panel();
            this.btnAddExams = new System.Windows.Forms.Button();
            this.btnChangeEx = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.btnAddQuestions = new System.Windows.Forms.Button();
            this.btnChangeQuestion = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.eclipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.animation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelExams.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuTextbox1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.animation.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 105);
            this.panel1.TabIndex = 1;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(970, 3);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(32, 32);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 5;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = global::QuizApp.Properties.Resources.ImageAdmin;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.InitialImage = global::QuizApp.Properties.Resources.ImageAdmin;
            this.bunifuImageButton2.Location = new System.Drawing.Point(931, 34);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // pictureBox1
            // 
            this.animation.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::QuizApp.Properties.Resources.triangle;
            this.pictureBox1.Location = new System.Drawing.Point(1008, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.animation.SetDecoration(this.lblUserName, BunifuAnimatorNS.DecorationType.None);
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblUserName.Location = new System.Drawing.Point(837, 57);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 20);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Welcome :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.animation.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(743, 57);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(88, 20);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Welcome :";
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animation.SetDecoration(this.bunifuTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(344, 32);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(292, 43);
            this.bunifuTextbox1.TabIndex = 1;
            this.bunifuTextbox1.text = "";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.animation.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(108, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(156, 23);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Multiple Choice";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.animation.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::QuizApp.Properties.Resources.question;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(23, 14);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(68, 61);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnMove);
            this.animation.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 558);
            this.panel5.TabIndex = 2;
            // 
            // pnMove
            // 
            this.pnMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.animation.SetDecoration(this.pnMove, BunifuAnimatorNS.DecorationType.None);
            this.pnMove.Location = new System.Drawing.Point(7, 73);
            this.pnMove.Name = "pnMove";
            this.pnMove.Size = new System.Drawing.Size(6, 39);
            this.pnMove.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.panelUser);
            this.panelMenu.Controls.Add(this.btnUser);
            this.panelMenu.Controls.Add(this.panelExams);
            this.panelMenu.Controls.Add(this.btnExams);
            this.panelMenu.Controls.Add(this.panelQuestion);
            this.panelMenu.Controls.Add(this.btnQuestion);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panel4);
            this.animation.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(13, 105);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(187, 558);
            this.panelMenu.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.animation.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 486);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(187, 39);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.btnAddUser);
            this.panelUser.Controls.Add(this.btnUserChange);
            this.animation.SetDecoration(this.panelUser, BunifuAnimatorNS.DecorationType.None);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 400);
            this.panelUser.Name = "panelUser";
            this.panelUser.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelUser.Size = new System.Drawing.Size(187, 86);
            this.panelUser.TabIndex = 8;
            // 
            // btnAddUser
            // 
            this.animation.SetDecoration(this.btnAddUser, BunifuAnimatorNS.DecorationType.None);
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(20, 0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(167, 39);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "   Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnChildControl_Click);
            // 
            // btnUserChange
            // 
            this.animation.SetDecoration(this.btnUserChange, BunifuAnimatorNS.DecorationType.None);
            this.btnUserChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUserChange.FlatAppearance.BorderSize = 0;
            this.btnUserChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserChange.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserChange.ForeColor = System.Drawing.Color.White;
            this.btnUserChange.Image = ((System.Drawing.Image)(resources.GetObject("btnUserChange.Image")));
            this.btnUserChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserChange.Location = new System.Drawing.Point(20, 47);
            this.btnUserChange.Name = "btnUserChange";
            this.btnUserChange.Size = new System.Drawing.Size(167, 39);
            this.btnUserChange.TabIndex = 7;
            this.btnUserChange.Text = "   User Change";
            this.btnUserChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserChange.UseVisualStyleBackColor = true;
            this.btnUserChange.Click += new System.EventHandler(this.btnChildControl_Click);
            // 
            // btnUser
            // 
            this.animation.SetDecoration(this.btnUser, BunifuAnimatorNS.DecorationType.None);
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 361);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(187, 39);
            this.btnUser.TabIndex = 9;
            this.btnUser.Text = "   User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // panelExams
            // 
            this.panelExams.Controls.Add(this.btnAddExams);
            this.panelExams.Controls.Add(this.btnChangeEx);
            this.animation.SetDecoration(this.panelExams, BunifuAnimatorNS.DecorationType.None);
            this.panelExams.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExams.Location = new System.Drawing.Point(0, 275);
            this.panelExams.Name = "panelExams";
            this.panelExams.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelExams.Size = new System.Drawing.Size(187, 86);
            this.panelExams.TabIndex = 8;
            // 
            // btnAddExams
            // 
            this.animation.SetDecoration(this.btnAddExams, BunifuAnimatorNS.DecorationType.None);
            this.btnAddExams.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddExams.FlatAppearance.BorderSize = 0;
            this.btnAddExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExams.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExams.ForeColor = System.Drawing.Color.White;
            this.btnAddExams.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExams.Image")));
            this.btnAddExams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddExams.Location = new System.Drawing.Point(20, 0);
            this.btnAddExams.Name = "btnAddExams";
            this.btnAddExams.Size = new System.Drawing.Size(167, 39);
            this.btnAddExams.TabIndex = 8;
            this.btnAddExams.Text = "   Add Exams";
            this.btnAddExams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddExams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddExams.UseVisualStyleBackColor = true;
            this.btnAddExams.Click += new System.EventHandler(this.btnChildControl_Click);
            // 
            // btnChangeEx
            // 
            this.animation.SetDecoration(this.btnChangeEx, BunifuAnimatorNS.DecorationType.None);
            this.btnChangeEx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangeEx.FlatAppearance.BorderSize = 0;
            this.btnChangeEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeEx.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEx.ForeColor = System.Drawing.Color.White;
            this.btnChangeEx.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeEx.Image")));
            this.btnChangeEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeEx.Location = new System.Drawing.Point(20, 38);
            this.btnChangeEx.Name = "btnChangeEx";
            this.btnChangeEx.Size = new System.Drawing.Size(167, 48);
            this.btnChangeEx.TabIndex = 10;
            this.btnChangeEx.Text = "   Change Exams";
            this.btnChangeEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeEx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeEx.UseVisualStyleBackColor = true;
            this.btnChangeEx.Click += new System.EventHandler(this.btnChildControl_Click);
            // 
            // btnExams
            // 
            this.animation.SetDecoration(this.btnExams, BunifuAnimatorNS.DecorationType.None);
            this.btnExams.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExams.FlatAppearance.BorderSize = 0;
            this.btnExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExams.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExams.ForeColor = System.Drawing.Color.White;
            this.btnExams.Image = ((System.Drawing.Image)(resources.GetObject("btnExams.Image")));
            this.btnExams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExams.Location = new System.Drawing.Point(0, 236);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(187, 39);
            this.btnExams.TabIndex = 11;
            this.btnExams.Text = "   Exams";
            this.btnExams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExams.UseVisualStyleBackColor = true;
            this.btnExams.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.btnAddQuestions);
            this.panelQuestion.Controls.Add(this.btnChangeQuestion);
            this.animation.SetDecoration(this.panelQuestion, BunifuAnimatorNS.DecorationType.None);
            this.panelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestion.Location = new System.Drawing.Point(0, 151);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelQuestion.Size = new System.Drawing.Size(187, 85);
            this.panelQuestion.TabIndex = 9;
            // 
            // btnAddQuestions
            // 
            this.animation.SetDecoration(this.btnAddQuestions, BunifuAnimatorNS.DecorationType.None);
            this.btnAddQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddQuestions.FlatAppearance.BorderSize = 0;
            this.btnAddQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestions.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestions.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddQuestions.Image")));
            this.btnAddQuestions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddQuestions.Location = new System.Drawing.Point(20, 0);
            this.btnAddQuestions.Name = "btnAddQuestions";
            this.btnAddQuestions.Size = new System.Drawing.Size(167, 39);
            this.btnAddQuestions.TabIndex = 7;
            this.btnAddQuestions.Text = "   Add Questions";
            this.btnAddQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddQuestions.UseVisualStyleBackColor = true;
            this.btnAddQuestions.Click += new System.EventHandler(this.btnChildControl_Click);
            // 
            // btnChangeQuestion
            // 
            this.animation.SetDecoration(this.btnChangeQuestion, BunifuAnimatorNS.DecorationType.None);
            this.btnChangeQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangeQuestion.FlatAppearance.BorderSize = 0;
            this.btnChangeQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeQuestion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeQuestion.ForeColor = System.Drawing.Color.White;
            this.btnChangeQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeQuestion.Image")));
            this.btnChangeQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeQuestion.Location = new System.Drawing.Point(20, 37);
            this.btnChangeQuestion.Name = "btnChangeQuestion";
            this.btnChangeQuestion.Size = new System.Drawing.Size(167, 48);
            this.btnChangeQuestion.TabIndex = 7;
            this.btnChangeQuestion.Text = "   Change Question";
            this.btnChangeQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeQuestion.UseVisualStyleBackColor = true;
            this.btnChangeQuestion.Click += new System.EventHandler(this.btnChildControl_Click);
            // 
            // btnQuestion
            // 
            this.animation.SetDecoration(this.btnQuestion, BunifuAnimatorNS.DecorationType.None);
            this.btnQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuestion.FlatAppearance.BorderSize = 0;
            this.btnQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestion.ForeColor = System.Drawing.Color.White;
            this.btnQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnQuestion.Image")));
            this.btnQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuestion.Location = new System.Drawing.Point(0, 112);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(187, 39);
            this.btnQuestion.TabIndex = 8;
            this.btnQuestion.Text = "   Question";
            this.btnQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnDashboard
            // 
            this.animation.SetDecoration(this.btnDashboard, BunifuAnimatorNS.DecorationType.None);
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 73);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(187, 39);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnChildControl_Click);
            // 
            // panel4
            // 
            this.animation.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 73);
            this.panel4.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.animation.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(896, 105);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(118, 558);
            this.panel7.TabIndex = 4;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.animation.SetDecoration(this.panel14, BunifuAnimatorNS.DecorationType.None);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(200, 105);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(696, 558);
            this.panel14.TabIndex = 8;
            // 
            // eclipse
            // 
            this.eclipse.ElipseRadius = 5;
            this.eclipse.TargetControl = this;
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1014, 663);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.animation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.Enter += new System.EventHandler(this.AdminForm_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelExams.ResumeLayout(false);
            this.panelQuestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnMove;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUserChange;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panelExams;
        private System.Windows.Forms.Button btnAddExams;
        private System.Windows.Forms.Button btnChangeEx;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Button btnAddQuestions;
        private System.Windows.Forms.Button btnChangeQuestion;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel14;
        private Bunifu.Framework.UI.BunifuElipse eclipse;
        private BunifuAnimatorNS.BunifuTransition animation;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timer1;
    }
}