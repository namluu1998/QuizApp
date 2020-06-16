namespace QuizApp
{
    partial class FormAddExams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddExams));
            this.examsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizappDataSet = new QuizApp.quizappDataSet();
            this.examsTableAdapter = new QuizApp.quizappDataSetTableAdapters.examsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rtxtCorrect = new System.Windows.Forms.RichTextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.cbxTypeQuestion = new System.Windows.Forms.ComboBox();
            this.rtxtOptionD = new System.Windows.Forms.RichTextBox();
            this.rtxtOptionC = new System.Windows.Forms.RichTextBox();
            this.rtxtOptionB = new System.Windows.Forms.RichTextBox();
            this.rtxtOptionA = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtQuestion = new System.Windows.Forms.RichTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.examsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizappDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.rtxtCorrect);
            this.panel1.Controls.Add(this.lblCorrect);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.cbxTypeQuestion);
            this.panel1.Controls.Add(this.rtxtOptionD);
            this.panel1.Controls.Add(this.rtxtOptionC);
            this.panel1.Controls.Add(this.rtxtOptionB);
            this.panel1.Controls.Add(this.rtxtOptionA);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rtxtQuestion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 494);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Add Exam";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.White;
            this.btnAdd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(227, 552);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 41);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(10, 471);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(629, 1);
            this.panel8.TabIndex = 65;
            // 
            // rtxtCorrect
            // 
            this.rtxtCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.rtxtCorrect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtCorrect.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtCorrect.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtxtCorrect.Location = new System.Drawing.Point(167, 417);
            this.rtxtCorrect.Name = "rtxtCorrect";
            this.rtxtCorrect.Size = new System.Drawing.Size(466, 48);
            this.rtxtCorrect.TabIndex = 63;
            this.rtxtCorrect.Text = "";
            // 
            // lblCorrect
            // 
            this.lblCorrect.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.DimGray;
            this.lblCorrect.Location = new System.Drawing.Point(6, 419);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(133, 35);
            this.lblCorrect.TabIndex = 64;
            this.lblCorrect.Text = "Correct :";
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(25, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 64);
            this.label6.TabIndex = 62;
            this.label6.Text = "Type Question";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(10, 405);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(629, 1);
            this.panel9.TabIndex = 61;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(10, 329);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(629, 1);
            this.panel10.TabIndex = 60;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(10, 254);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(629, 1);
            this.panel11.TabIndex = 58;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(10, 182);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(629, 1);
            this.panel12.TabIndex = 59;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(19, 102);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(629, 1);
            this.panel13.TabIndex = 57;
            // 
            // cbxTypeQuestion
            // 
            this.cbxTypeQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.cbxTypeQuestion.DataSource = this.examsBindingSource;
            this.cbxTypeQuestion.DisplayMember = "exam_name";
            this.cbxTypeQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTypeQuestion.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbxTypeQuestion.FormattingEnabled = true;
            this.cbxTypeQuestion.Location = new System.Drawing.Point(167, 495);
            this.cbxTypeQuestion.Name = "cbxTypeQuestion";
            this.cbxTypeQuestion.Size = new System.Drawing.Size(466, 21);
            this.cbxTypeQuestion.TabIndex = 51;
            this.cbxTypeQuestion.ValueMember = "exam_name";
            // 
            // rtxtOptionD
            // 
            this.rtxtOptionD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.rtxtOptionD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtOptionD.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOptionD.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtxtOptionD.Location = new System.Drawing.Point(167, 351);
            this.rtxtOptionD.Name = "rtxtOptionD";
            this.rtxtOptionD.Size = new System.Drawing.Size(466, 48);
            this.rtxtOptionD.TabIndex = 50;
            this.rtxtOptionD.Text = "";
            // 
            // rtxtOptionC
            // 
            this.rtxtOptionC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.rtxtOptionC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtOptionC.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOptionC.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtxtOptionC.Location = new System.Drawing.Point(167, 275);
            this.rtxtOptionC.Name = "rtxtOptionC";
            this.rtxtOptionC.Size = new System.Drawing.Size(466, 48);
            this.rtxtOptionC.TabIndex = 49;
            this.rtxtOptionC.Text = "";
            // 
            // rtxtOptionB
            // 
            this.rtxtOptionB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.rtxtOptionB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtOptionB.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOptionB.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtxtOptionB.Location = new System.Drawing.Point(167, 200);
            this.rtxtOptionB.Name = "rtxtOptionB";
            this.rtxtOptionB.Size = new System.Drawing.Size(466, 48);
            this.rtxtOptionB.TabIndex = 48;
            this.rtxtOptionB.Text = "";
            // 
            // rtxtOptionA
            // 
            this.rtxtOptionA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.rtxtOptionA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtOptionA.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOptionA.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtxtOptionA.Location = new System.Drawing.Point(167, 128);
            this.rtxtOptionA.Name = "rtxtOptionA";
            this.rtxtOptionA.Size = new System.Drawing.Size(466, 48);
            this.rtxtOptionA.TabIndex = 47;
            this.rtxtOptionA.Text = "";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(6, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 35);
            this.label5.TabIndex = 56;
            this.label5.Text = "Option D :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(6, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 35);
            this.label4.TabIndex = 55;
            this.label4.Text = "Option C :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(6, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 35);
            this.label3.TabIndex = 54;
            this.label3.Text = "Option B :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 35);
            this.label2.TabIndex = 53;
            this.label2.Text = "Option A :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 61);
            this.label1.TabIndex = 52;
            this.label1.Text = "Question : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtQuestion
            // 
            this.rtxtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.rtxtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtQuestion.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtxtQuestion.Location = new System.Drawing.Point(167, 12);
            this.rtxtQuestion.Name = "rtxtQuestion";
            this.rtxtQuestion.Size = new System.Drawing.Size(466, 82);
            this.rtxtQuestion.TabIndex = 46;
            this.rtxtQuestion.Text = "";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // examsBindingSource1
            // 
            this.examsBindingSource1.DataMember = "exams";
            this.examsBindingSource1.DataSource = this.quizappDataSet;
            // 
            // FormAddExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 494);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddExams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddExamples";
            this.Load += new System.EventHandler(this.FormAddExamples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizappDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtQuestion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RichTextBox rtxtCorrect;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RichTextBox rtxtOptionD;
        private System.Windows.Forms.RichTextBox rtxtOptionC;
        private System.Windows.Forms.RichTextBox rtxtOptionB;
        private System.Windows.Forms.RichTextBox rtxtOptionA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel1;
        public quizappDataSet quizappDataSet;
        public System.Windows.Forms.BindingSource examsBindingSource;
        public quizappDataSetTableAdapters.examsTableAdapter examsTableAdapter;
        public System.Windows.Forms.ComboBox cbxTypeQuestion;
        public System.Windows.Forms.BindingSource examsBindingSource1;
    }
}