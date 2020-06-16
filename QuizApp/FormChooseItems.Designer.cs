namespace QuizApp
{
    partial class FormChooseItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudents));
            this.ptcAdmin = new System.Windows.Forms.PictureBox();
            this.ptcStudents = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.ptcExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcExit)).BeginInit();
            this.SuspendLayout();
            // 
            // ptcAdmin
            // 
            this.ptcAdmin.BackColor = System.Drawing.Color.Transparent;
            this.ptcAdmin.BackgroundImage = global::QuizApp.Properties.Resources.Admin_icon;
            this.ptcAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcAdmin.Location = new System.Drawing.Point(62, 75);
            this.ptcAdmin.Name = "ptcAdmin";
            this.ptcAdmin.Size = new System.Drawing.Size(238, 184);
            this.ptcAdmin.TabIndex = 0;
            this.ptcAdmin.TabStop = false;
            this.ptcAdmin.Click += new System.EventHandler(this.ptcAdmin_Click);
            this.ptcAdmin.MouseLeave += new System.EventHandler(this.ptcAdmin_MouseLeave);
            this.ptcAdmin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptcAdmin_MouseMove);
            // 
            // ptcStudents
            // 
            this.ptcStudents.BackColor = System.Drawing.Color.Transparent;
            this.ptcStudents.BackgroundImage = global::QuizApp.Properties.Resources.User_Group_icon;
            this.ptcStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcStudents.Location = new System.Drawing.Point(383, 75);
            this.ptcStudents.Name = "ptcStudents";
            this.ptcStudents.Size = new System.Drawing.Size(246, 184);
            this.ptcStudents.TabIndex = 1;
            this.ptcStudents.TabStop = false;
            this.ptcStudents.MouseLeave += new System.EventHandler(this.ptcStudents_MouseLeave);
            this.ptcStudents.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptcStudents_MouseMove);
            // 
            // lblAdmin
            // 
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblAdmin.Location = new System.Drawing.Point(126, 281);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(108, 36);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdmin.MouseLeave += new System.EventHandler(this.ptcAdmin_MouseLeave);
            this.lblAdmin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptcAdmin_MouseMove);
            // 
            // lblStudents
            // 
            this.lblStudents.BackColor = System.Drawing.Color.Transparent;
            this.lblStudents.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblStudents.Location = new System.Drawing.Point(453, 281);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(108, 36);
            this.lblStudents.TabIndex = 3;
            this.lblStudents.Text = "Students";
            this.lblStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStudents.MouseLeave += new System.EventHandler(this.ptcStudents_MouseLeave);
            this.lblStudents.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptcStudents_MouseMove);
            // 
            // ptcExit
            // 
            this.ptcExit.BackColor = System.Drawing.Color.Transparent;
            this.ptcExit.BackgroundImage = global::QuizApp.Properties.Resources.Exit;
            this.ptcExit.Location = new System.Drawing.Point(679, 0);
            this.ptcExit.Name = "ptcExit";
            this.ptcExit.Size = new System.Drawing.Size(24, 24);
            this.ptcExit.TabIndex = 4;
            this.ptcExit.TabStop = false;
            this.ptcExit.Click += new System.EventHandler(this.ptcExit_Click);
            this.ptcExit.MouseLeave += new System.EventHandler(this.ptcExit_MouseLeave);
            this.ptcExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptcExit_MouseMove);
            // 
            // FormChooseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 389);
            this.Controls.Add(this.ptcExit);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.ptcStudents);
            this.Controls.Add(this.ptcAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChooseItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChooseItem";
            ((System.ComponentModel.ISupportInitialize)(this.ptcAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcAdmin;
        private System.Windows.Forms.PictureBox ptcStudents;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.PictureBox ptcExit;
    }
}