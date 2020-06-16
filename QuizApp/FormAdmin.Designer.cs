namespace QuizApp
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChangeExams = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeleteExams = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddExams = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.examsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizappDataSet = new QuizApp.quizappDataSet();
            this.kryptonContextMenu1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.examsTableAdapter = new QuizApp.quizappDataSetTableAdapters.examsTableAdapter();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizappDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuTextbox1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 93);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::QuizApp.Properties.Resources.ImageAdmin;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.InitialImage = global::QuizApp.Properties.Resources.ImageAdmin;
            this.bunifuImageButton2.Location = new System.Drawing.Point(911, 19);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuizApp.Properties.Resources.triangle;
            this.pictureBox1.Location = new System.Drawing.Point(990, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblUserName.Location = new System.Drawing.Point(817, 42);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 20);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Welcome :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(723, 42);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(88, 20);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Welcome :";
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.AutoSize = true;
            this.bunifuTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(344, 29);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(293, 42);
            this.bunifuTextbox1.TabIndex = 1;
            this.bunifuTextbox1.text = "";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(113, 36);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(156, 23);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Multiple Choice";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::QuizApp.Properties.Resources.question;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(28, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(68, 61);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.btnChangeExams);
            this.panel2.Controls.Add(this.btnDeleteExams);
            this.panel2.Controls.Add(this.btnAddExams);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 486);
            this.panel2.TabIndex = 1;
            // 
            // btnChangeExams
            // 
            this.btnChangeExams.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnChangeExams.ActiveBorderThickness = 1;
            this.btnChangeExams.ActiveCornerRadius = 12;
            this.btnChangeExams.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnChangeExams.ActiveForecolor = System.Drawing.Color.White;
            this.btnChangeExams.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnChangeExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnChangeExams.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeExams.BackgroundImage")));
            this.btnChangeExams.ButtonText = "Change Exams";
            this.btnChangeExams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeExams.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeExams.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnChangeExams.IdleBorderThickness = 1;
            this.btnChangeExams.IdleCornerRadius = 20;
            this.btnChangeExams.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnChangeExams.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeExams.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnChangeExams.Location = new System.Drawing.Point(14, 213);
            this.btnChangeExams.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangeExams.Name = "btnChangeExams";
            this.btnChangeExams.Size = new System.Drawing.Size(181, 32);
            this.btnChangeExams.TabIndex = 6;
            this.btnChangeExams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangeExams.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // btnDeleteExams
            // 
            this.btnDeleteExams.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnDeleteExams.ActiveBorderThickness = 1;
            this.btnDeleteExams.ActiveCornerRadius = 12;
            this.btnDeleteExams.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnDeleteExams.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteExams.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnDeleteExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnDeleteExams.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteExams.BackgroundImage")));
            this.btnDeleteExams.ButtonText = "Delete Exams";
            this.btnDeleteExams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteExams.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExams.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteExams.IdleBorderThickness = 1;
            this.btnDeleteExams.IdleCornerRadius = 20;
            this.btnDeleteExams.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnDeleteExams.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteExams.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnDeleteExams.Location = new System.Drawing.Point(14, 171);
            this.btnDeleteExams.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteExams.Name = "btnDeleteExams";
            this.btnDeleteExams.Size = new System.Drawing.Size(181, 32);
            this.btnDeleteExams.TabIndex = 5;
            this.btnDeleteExams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteExams.Click += new System.EventHandler(this.btnDeleteExams_Click);
            // 
            // btnAddExams
            // 
            this.btnAddExams.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnAddExams.ActiveBorderThickness = 1;
            this.btnAddExams.ActiveCornerRadius = 12;
            this.btnAddExams.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnAddExams.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddExams.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnAddExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnAddExams.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddExams.BackgroundImage")));
            this.btnAddExams.ButtonText = "Add Exams";
            this.btnAddExams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddExams.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExams.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddExams.IdleBorderThickness = 1;
            this.btnAddExams.IdleCornerRadius = 20;
            this.btnAddExams.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAddExams.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddExams.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnAddExams.Location = new System.Drawing.Point(14, 129);
            this.btnAddExams.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddExams.Name = "btnAddExams";
            this.btnAddExams.Size = new System.Drawing.Size(181, 32);
            this.btnAddExams.TabIndex = 4;
            this.btnAddExams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddExams.Click += new System.EventHandler(this.btnAddExams_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnDashboard.ActiveBorderThickness = 1;
            this.btnDashboard.ActiveCornerRadius = 12;
            this.btnDashboard.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.ActiveForecolor = System.Drawing.Color.White;
            this.btnDashboard.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.BackgroundImage")));
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDashboard.IdleBorderThickness = 1;
            this.btnDashboard.IdleCornerRadius = 20;
            this.btnDashboard.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Location = new System.Drawing.Point(14, 87);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(181, 32);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panel6.Location = new System.Drawing.Point(3, 211);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(6, 32);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panel5.Location = new System.Drawing.Point(3, 169);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 32);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panel4.Location = new System.Drawing.Point(3, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 32);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panel3.Location = new System.Drawing.Point(3, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 32);
            this.panel3.TabIndex = 2;
            // 
            // examsBindingSource
            // 
            this.examsBindingSource.DataMember = "exams";
            this.examsBindingSource.DataSource = this.quizappDataSet;
            // 
            // quizappDataSet
            // 
            this.quizappDataSet.DataSetName = "quizappDataSet";
            this.quizappDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examsTableAdapter
            // 
            this.examsTableAdapter.ClearBeforeFill = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(873, 93);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(141, 486);
            this.panel7.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(200, 93);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(673, 486);
            this.panel14.TabIndex = 7;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1014, 579);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizappDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDashboard;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChangeExams;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteExams;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddExams;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private quizappDataSet quizappDataSet;
        private System.Windows.Forms.BindingSource examsBindingSource;
        private quizappDataSetTableAdapters.examsTableAdapter examsTableAdapter;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel14;
    }
}