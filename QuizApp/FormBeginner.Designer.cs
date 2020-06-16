namespace QuizApp
{
    partial class FormBeginner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBeginner));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ptcOpA = new System.Windows.Forms.PictureBox();
            this.lblOpA = new System.Windows.Forms.Label();
            this.ptcOpB = new System.Windows.Forms.PictureBox();
            this.lblOpB = new System.Windows.Forms.Label();
            this.ptcOpC = new System.Windows.Forms.PictureBox();
            this.ptcOpD = new System.Windows.Forms.PictureBox();
            this.lblOpD = new System.Windows.Forms.Label();
            this.lblOpC = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptcOpA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcOpB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcOpC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcOpD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblQuestion.Location = new System.Drawing.Point(100, 153);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(920, 93);
            this.lblQuestion.TabIndex = 11;
            this.lblQuestion.Text = "label1";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Snow;
            this.btnNext.Location = new System.Drawing.Point(925, 93);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 32);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Snow;
            this.btnBack.Location = new System.Drawing.Point(65, 105);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 32);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(218, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Câu hỏi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndex
            // 
            this.lblIndex.BackColor = System.Drawing.Color.Transparent;
            this.lblIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIndex.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIndex.Location = new System.Drawing.Point(306, 47);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(60, 43);
            this.lblIndex.TabIndex = 8;
            this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(974, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 57);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ptcOpA
            // 
            this.ptcOpA.BackColor = System.Drawing.Color.Transparent;
            this.ptcOpA.BackgroundImage = global::QuizApp.Properties.Resources.OptionA1;
            this.ptcOpA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcOpA.Location = new System.Drawing.Point(60, 309);
            this.ptcOpA.Name = "ptcOpA";
            this.ptcOpA.Size = new System.Drawing.Size(463, 87);
            this.ptcOpA.TabIndex = 10;
            this.ptcOpA.TabStop = false;
            this.ptcOpA.Visible = false;
            // 
            // lblOpA
            // 
            this.lblOpA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(121)))), ((int)(((byte)(64)))));
            this.lblOpA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOpA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpA.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpA.ForeColor = System.Drawing.Color.White;
            this.lblOpA.Location = new System.Drawing.Point(142, 309);
            this.lblOpA.Name = "lblOpA";
            this.lblOpA.Size = new System.Drawing.Size(338, 87);
            this.lblOpA.TabIndex = 12;
            this.lblOpA.Text = "dqwjadjk";
            this.lblOpA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpA.Click += new System.EventHandler(this.lblOp_Click);
            this.lblOpA.MouseLeave += new System.EventHandler(this.lblOp_MouseLeave);
            this.lblOpA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblOp_MouseMove);
            // 
            // ptcOpB
            // 
            this.ptcOpB.BackColor = System.Drawing.Color.Transparent;
            this.ptcOpB.BackgroundImage = global::QuizApp.Properties.Resources.OptionB;
            this.ptcOpB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcOpB.Location = new System.Drawing.Point(588, 309);
            this.ptcOpB.Name = "ptcOpB";
            this.ptcOpB.Size = new System.Drawing.Size(463, 87);
            this.ptcOpB.TabIndex = 13;
            this.ptcOpB.TabStop = false;
            this.ptcOpB.Visible = false;
            // 
            // lblOpB
            // 
            this.lblOpB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(121)))), ((int)(((byte)(64)))));
            this.lblOpB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOpB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpB.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpB.ForeColor = System.Drawing.Color.White;
            this.lblOpB.Location = new System.Drawing.Point(669, 309);
            this.lblOpB.Name = "lblOpB";
            this.lblOpB.Size = new System.Drawing.Size(338, 87);
            this.lblOpB.TabIndex = 14;
            this.lblOpB.Text = "dqwjadjk";
            this.lblOpB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpB.Click += new System.EventHandler(this.lblOp_Click);
            this.lblOpB.MouseLeave += new System.EventHandler(this.lblOp_MouseLeave);
            this.lblOpB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblOp_MouseMove);
            // 
            // ptcOpC
            // 
            this.ptcOpC.BackColor = System.Drawing.Color.Transparent;
            this.ptcOpC.BackgroundImage = global::QuizApp.Properties.Resources.OptionC;
            this.ptcOpC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcOpC.Location = new System.Drawing.Point(61, 432);
            this.ptcOpC.Name = "ptcOpC";
            this.ptcOpC.Size = new System.Drawing.Size(463, 87);
            this.ptcOpC.TabIndex = 15;
            this.ptcOpC.TabStop = false;
            this.ptcOpC.Visible = false;
            // 
            // ptcOpD
            // 
            this.ptcOpD.BackColor = System.Drawing.Color.Transparent;
            this.ptcOpD.BackgroundImage = global::QuizApp.Properties.Resources.OptionD;
            this.ptcOpD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcOpD.Location = new System.Drawing.Point(588, 433);
            this.ptcOpD.Name = "ptcOpD";
            this.ptcOpD.Size = new System.Drawing.Size(463, 87);
            this.ptcOpD.TabIndex = 16;
            this.ptcOpD.TabStop = false;
            this.ptcOpD.Visible = false;
            // 
            // lblOpD
            // 
            this.lblOpD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(121)))), ((int)(((byte)(64)))));
            this.lblOpD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOpD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpD.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpD.ForeColor = System.Drawing.Color.White;
            this.lblOpD.Location = new System.Drawing.Point(669, 433);
            this.lblOpD.Name = "lblOpD";
            this.lblOpD.Size = new System.Drawing.Size(338, 87);
            this.lblOpD.TabIndex = 17;
            this.lblOpD.Text = "dqwjadjk";
            this.lblOpD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpD.Click += new System.EventHandler(this.lblOp_Click);
            this.lblOpD.MouseLeave += new System.EventHandler(this.lblOp_MouseLeave);
            this.lblOpD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblOp_MouseMove);
            // 
            // lblOpC
            // 
            this.lblOpC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(121)))), ((int)(((byte)(64)))));
            this.lblOpC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOpC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpC.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpC.ForeColor = System.Drawing.Color.White;
            this.lblOpC.Location = new System.Drawing.Point(142, 432);
            this.lblOpC.Name = "lblOpC";
            this.lblOpC.Size = new System.Drawing.Size(338, 87);
            this.lblOpC.TabIndex = 18;
            this.lblOpC.Text = "dqwjadjk";
            this.lblOpC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpC.Click += new System.EventHandler(this.lblOp_Click);
            this.lblOpC.MouseLeave += new System.EventHandler(this.lblOp_MouseLeave);
            this.lblOpC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblOp_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 57);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(646, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 43);
            this.label2.TabIndex = 20;
            this.label2.Text = "Time :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // lblTimes
            // 
            this.lblTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimes.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTimes.Location = new System.Drawing.Point(742, 47);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(125, 43);
            this.lblTimes.TabIndex = 21;
            this.lblTimes.Text = "0";
            this.lblTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimes.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(409, 93);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 23;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormBeginner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 563);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.lblTimes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblOpC);
            this.Controls.Add(this.lblOpD);
            this.Controls.Add(this.ptcOpD);
            this.Controls.Add(this.ptcOpC);
            this.Controls.Add(this.lblOpB);
            this.Controls.Add(this.ptcOpB);
            this.Controls.Add(this.lblOpA);
            this.Controls.Add(this.ptcOpA);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblQuestion);
            this.Name = "FormBeginner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormBeginner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcOpA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcOpB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcOpC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcOpD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox ptcOpA;
        private System.Windows.Forms.Label lblOpA;
        private System.Windows.Forms.PictureBox ptcOpB;
        private System.Windows.Forms.Label lblOpB;
        private System.Windows.Forms.PictureBox ptcOpC;
        private System.Windows.Forms.PictureBox ptcOpD;
        private System.Windows.Forms.Label lblOpD;
        private System.Windows.Forms.Label lblOpC;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}