namespace QuizApp
{
    partial class DisplayResultStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayResultStartForm));
            this.pnContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnQs = new System.Windows.Forms.Panel();
            this.lblQs = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblDetail = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnDetail = new System.Windows.Forms.Panel();
            this.checkResult = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkOp = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ptcOp = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblResult = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnQs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail)).BeginInit();
            this.pnDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcOp)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.Azure;
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(36, 59);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(542, 760);
            this.pnContent.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 59);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 760);
            this.panel2.TabIndex = 1;
            // 
            // pnQs
            // 
            this.pnQs.BackColor = System.Drawing.Color.Transparent;
            this.pnQs.BackgroundImage = global::QuizApp.Properties.Resources.ResultQs;
            this.pnQs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnQs.Controls.Add(this.lblDetail);
            this.pnQs.Controls.Add(this.Check);
            this.pnQs.Controls.Add(this.lblQs);
            this.pnQs.Location = new System.Drawing.Point(6, 94);
            this.pnQs.Name = "pnQs";
            this.pnQs.Size = new System.Drawing.Size(542, 113);
            this.pnQs.TabIndex = 1;
            this.pnQs.Visible = false;
            // 
            // lblQs
            // 
            this.lblQs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQs.Location = new System.Drawing.Point(98, 14);
            this.lblQs.Name = "lblQs";
            this.lblQs.Size = new System.Drawing.Size(328, 96);
            this.lblQs.TabIndex = 0;
            this.lblQs.Text = "Question";
            this.lblQs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Check.Checked = true;
            this.Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Check.ForeColor = System.Drawing.Color.White;
            this.Check.Location = new System.Drawing.Point(432, 56);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(20, 20);
            this.Check.TabIndex = 1;
            // 
            // lblDetail
            // 
            this.lblDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblDetail.Image = global::QuizApp.Properties.Resources.chevron_down;
            this.lblDetail.ImageActive = null;
            this.lblDetail.Location = new System.Drawing.Point(488, 45);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(36, 35);
            this.lblDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblDetail.TabIndex = 2;
            this.lblDetail.TabStop = false;
            this.lblDetail.Zoom = 10;
            this.lblDetail.Click += new System.EventHandler(this.lblDetail_Click);
            // 
            // pnDetail
            // 
            this.pnDetail.BackgroundImage = global::QuizApp.Properties.Resources.Result;
            this.pnDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnDetail.Controls.Add(this.lblResult);
            this.pnDetail.Controls.Add(this.ptcOp);
            this.pnDetail.Controls.Add(this.checkOp);
            this.pnDetail.Controls.Add(this.checkResult);
            this.pnDetail.Location = new System.Drawing.Point(6, 207);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(542, 81);
            this.pnDetail.TabIndex = 2;
            this.pnDetail.Visible = false;
            // 
            // checkResult
            // 
            this.checkResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkResult.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkResult.Checked = true;
            this.checkResult.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkResult.ForeColor = System.Drawing.Color.White;
            this.checkResult.Location = new System.Drawing.Point(432, 32);
            this.checkResult.Name = "checkResult";
            this.checkResult.Size = new System.Drawing.Size(20, 20);
            this.checkResult.TabIndex = 1;
            // 
            // checkOp
            // 
            this.checkOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkOp.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkOp.Checked = true;
            this.checkOp.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkOp.ForeColor = System.Drawing.Color.White;
            this.checkOp.Location = new System.Drawing.Point(472, 32);
            this.checkOp.Name = "checkOp";
            this.checkOp.Size = new System.Drawing.Size(20, 20);
            this.checkOp.TabIndex = 2;
            // 
            // ptcOp
            // 
            this.ptcOp.BackColor = System.Drawing.Color.Transparent;
            this.ptcOp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcOp.Image = ((System.Drawing.Image)(resources.GetObject("ptcOp.Image")));
            this.ptcOp.ImageActive = null;
            this.ptcOp.Location = new System.Drawing.Point(163, 8);
            this.ptcOp.Name = "ptcOp";
            this.ptcOp.Size = new System.Drawing.Size(159, 60);
            this.ptcOp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcOp.TabIndex = 1;
            this.ptcOp.TabStop = false;
            this.ptcOp.Zoom = 10;
            this.ptcOp.Click += new System.EventHandler(this.ptcOp_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(98, 1);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(330, 80);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.pnDetail);
            this.panel3.Controls.Add(this.pnQs);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(578, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 760);
            this.panel3.TabIndex = 2;
            // 
            // DisplayResultStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 819);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayResultStartForm";
            this.Text = "DisplayResultStartForm";
            this.Load += new System.EventHandler(this.DisplayResultStartForm_Load);
            this.pnQs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail)).EndInit();
            this.pnDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcOp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnQs;
        private Bunifu.Framework.UI.BunifuImageButton lblDetail;
        private Bunifu.Framework.UI.BunifuCheckbox Check;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQs;
        private System.Windows.Forms.Panel pnDetail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblResult;
        private Bunifu.Framework.UI.BunifuImageButton ptcOp;
        private Bunifu.Framework.UI.BunifuCheckbox checkOp;
        private Bunifu.Framework.UI.BunifuCheckbox checkResult;
        private System.Windows.Forms.Panel panel3;
    }
}