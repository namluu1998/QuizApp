namespace QuizApp
{
    partial class WaitAdminForm
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
            this.tranColor = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDots = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.eclipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tranColor
            // 
            this.tranColor.Color1 = System.Drawing.Color.White;
            this.tranColor.Color2 = System.Drawing.Color.Black;
            this.tranColor.ProgessValue = 0;
            this.tranColor.OnValueChange += new System.EventHandler(this.color_OnValueChange);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(127, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(107, 21);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Admin Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuizApp.Properties.Resources.businesswoman;
            this.pictureBox1.Location = new System.Drawing.Point(136, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDots
            // 
            this.btnDots.AutoSize = true;
            this.btnDots.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDots.ForeColor = System.Drawing.Color.White;
            this.btnDots.Location = new System.Drawing.Point(159, 168);
            this.btnDots.Name = "btnDots";
            this.btnDots.Size = new System.Drawing.Size(18, 21);
            this.btnDots.TabIndex = 0;
            this.btnDots.Text = ". ";
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1000;
            // 
            // eclipse
            // 
            this.eclipse.ElipseRadius = 15;
            this.eclipse.TargetControl = this;
            // 
            // WaitAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(397, 221);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDots);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaitAdminForm";
            this.Load += new System.EventHandler(this.WaitAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuColorTransition tranColor;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomLabel txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel btnDots;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private Bunifu.Framework.UI.BunifuElipse eclipse;
    }
}