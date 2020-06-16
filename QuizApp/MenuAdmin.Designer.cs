namespace QuizApp
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.lblAddExamples = new System.Windows.Forms.Label();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.ptcAddExamples = new System.Windows.Forms.PictureBox();
            this.ptcAddUser = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAddExamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAddUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddExamples
            // 
            this.lblAddExamples.BackColor = System.Drawing.Color.Transparent;
            this.lblAddExamples.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddExamples.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblAddExamples.Location = new System.Drawing.Point(54, 235);
            this.lblAddExamples.Name = "lblAddExamples";
            this.lblAddExamples.Size = new System.Drawing.Size(176, 56);
            this.lblAddExamples.TabIndex = 7;
            this.lblAddExamples.Text = "Add Examples";
            this.lblAddExamples.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddExamples.MouseLeave += new System.EventHandler(this.ptcAddExamples_MouseLeave);
            this.lblAddExamples.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptcAddExamples_MouseMove);
            // 
            // lblAddUser
            // 
            this.lblAddUser.BackColor = System.Drawing.Color.Transparent;
            this.lblAddUser.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblAddUser.Location = new System.Drawing.Point(93, 245);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(108, 36);
            this.lblAddUser.TabIndex = 6;
            this.lblAddUser.Text = "Add User";
            this.lblAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddUser.MouseLeave += new System.EventHandler(this.ptcAddUser_MouseLeave);
            this.lblAddUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptcAddUser_MouseMove);
            // 
            // ptcAddExamples
            // 
            this.ptcAddExamples.BackColor = System.Drawing.Color.Transparent;
            this.ptcAddExamples.BackgroundImage = global::QuizApp.Properties.Resources.quizMove;
            this.ptcAddExamples.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcAddExamples.Location = new System.Drawing.Point(56, 39);
            this.ptcAddExamples.Name = "ptcAddExamples";
            this.ptcAddExamples.Size = new System.Drawing.Size(174, 139);
            this.ptcAddExamples.TabIndex = 5;
            this.ptcAddExamples.TabStop = false;
            this.ptcAddExamples.Click += new System.EventHandler(this.ptcAddExamples_Click);
            this.ptcAddExamples.MouseLeave += new System.EventHandler(this.ptcAddExamples_MouseLeave);
            this.ptcAddExamples.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptcAddExamples_MouseMove);
            // 
            // ptcAddUser
            // 
            this.ptcAddUser.BackColor = System.Drawing.Color.Transparent;
            this.ptcAddUser.BackgroundImage = global::QuizApp.Properties.Resources.AddStudents;
            this.ptcAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcAddUser.Location = new System.Drawing.Point(50, 45);
            this.ptcAddUser.Name = "ptcAddUser";
            this.ptcAddUser.Size = new System.Drawing.Size(183, 133);
            this.ptcAddUser.TabIndex = 4;
            this.ptcAddUser.TabStop = false;
            this.ptcAddUser.MouseLeave += new System.EventHandler(this.ptcAddUser_MouseLeave);
            this.ptcAddUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptcAddUser_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ptcAddUser);
            this.groupBox1.Controls.Add(this.lblAddUser);
            this.groupBox1.Location = new System.Drawing.Point(53, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 356);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ptcAddExamples);
            this.groupBox2.Controls.Add(this.lblAddExamples);
            this.groupBox2.Location = new System.Drawing.Point(422, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 356);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.ptcAddExamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAddUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddExamples;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.PictureBox ptcAddExamples;
        private System.Windows.Forms.PictureBox ptcAddUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}