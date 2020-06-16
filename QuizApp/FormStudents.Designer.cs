namespace QuizApp
{
    partial class FormStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudents));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnStart = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbxChooseExam = new System.Windows.Forms.ComboBox();
            this.examsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizappDataSet = new QuizApp.quizappDataSet();
            this.examsTableAdapter = new QuizApp.quizappDataSetTableAdapters.examsTableAdapter();
            this.examsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSetting = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbxSelectNumExams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTimes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizappDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::QuizApp.Properties.Resources.Backspace;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(5, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(47, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.lblName);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.HotPink;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(27)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(325, 48);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(136, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // btnExit
            // 
            this.btnExit.ActiveBorderThickness = 1;
            this.btnExit.ActiveCornerRadius = 20;
            this.btnExit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnExit.ActiveForecolor = System.Drawing.Color.White;
            this.btnExit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = "Exit";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleCornerRadius = 20;
            this.btnExit.IdleFillColor = System.Drawing.Color.White;
            this.btnExit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnExit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnExit.Location = new System.Drawing.Point(70, 353);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.ActiveBorderThickness = 1;
            this.btnStart.ActiveCornerRadius = 20;
            this.btnStart.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnStart.ActiveForecolor = System.Drawing.Color.White;
            this.btnStart.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.ButtonText = "Start";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnStart.IdleBorderThickness = 1;
            this.btnStart.IdleCornerRadius = 20;
            this.btnStart.IdleFillColor = System.Drawing.Color.White;
            this.btnStart.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnStart.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnStart.Location = new System.Drawing.Point(70, 220);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 41);
            this.btnStart.TabIndex = 3;
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbxChooseExam
            // 
            this.cbxChooseExam.DataSource = this.examsBindingSource;
            this.cbxChooseExam.DisplayMember = "exam_name";
            this.cbxChooseExam.FormattingEnabled = true;
            this.cbxChooseExam.Location = new System.Drawing.Point(156, 149);
            this.cbxChooseExam.Name = "cbxChooseExam";
            this.cbxChooseExam.Size = new System.Drawing.Size(121, 21);
            this.cbxChooseExam.TabIndex = 4;
            this.cbxChooseExam.ValueMember = "ex_id";
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
            // examsBindingSource1
            // 
            this.examsBindingSource1.DataMember = "exams";
            this.examsBindingSource1.DataSource = this.quizappDataSet;
            // 
            // btnSetting
            // 
            this.btnSetting.ActiveBorderThickness = 1;
            this.btnSetting.ActiveCornerRadius = 20;
            this.btnSetting.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSetting.ActiveForecolor = System.Drawing.Color.White;
            this.btnSetting.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSetting.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.ButtonText = "Setting";
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSetting.IdleBorderThickness = 1;
            this.btnSetting.IdleCornerRadius = 20;
            this.btnSetting.IdleFillColor = System.Drawing.Color.White;
            this.btnSetting.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSetting.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSetting.Location = new System.Drawing.Point(70, 287);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(181, 41);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // cbxSelectNumExams
            // 
            this.cbxSelectNumExams.DisplayMember = "ex_id";
            this.cbxSelectNumExams.FormattingEnabled = true;
            this.cbxSelectNumExams.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.cbxSelectNumExams.Location = new System.Drawing.Point(156, 107);
            this.cbxSelectNumExams.Name = "cbxSelectNumExams";
            this.cbxSelectNumExams.Size = new System.Drawing.Size(121, 21);
            this.cbxSelectNumExams.TabIndex = 6;
            this.cbxSelectNumExams.Text = "1";
            this.cbxSelectNumExams.ValueMember = "ex_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Num Question :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name Exams :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 45);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time anwer 1 Question(s) :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxTimes
            // 
            this.cbxTimes.FormattingEnabled = true;
            this.cbxTimes.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "60"});
            this.cbxTimes.Location = new System.Drawing.Point(156, 191);
            this.cbxTimes.Name = "cbxTimes";
            this.cbxTimes.Size = new System.Drawing.Size(121, 21);
            this.cbxTimes.TabIndex = 10;
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 571);
            this.Controls.Add(this.cbxTimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSelectNumExams);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.cbxChooseExam);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChooseExams";
            this.Load += new System.EventHandler(this.FormChooseExams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizappDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStart;
        private System.Windows.Forms.ComboBox cbxChooseExam;
        private quizappDataSet quizappDataSet;
        private System.Windows.Forms.BindingSource examsBindingSource;
        private quizappDataSetTableAdapters.examsTableAdapter examsTableAdapter;
        private System.Windows.Forms.BindingSource examsBindingSource1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSetting;
        private System.Windows.Forms.ComboBox cbxSelectNumExams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTimes;
    }
}