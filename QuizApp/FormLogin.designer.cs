namespace QuizApp
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.timeStart = new System.Windows.Forms.Timer(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.ptcTwitter = new System.Windows.Forms.PictureBox();
            this.ptcGoogle = new System.Windows.Forms.PictureBox();
            this.ptcFacebook = new System.Windows.Forms.PictureBox();
            this.ptcPassword = new System.Windows.Forms.PictureBox();
            this.ptcUsername = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGoogle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(79, 135);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(152, 15);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(50, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(50, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(79, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 15);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogin.Location = new System.Drawing.Point(50, 256);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 33);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(50, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // timeStart
            // 
            this.timeStart.Enabled = true;
            this.timeStart.Interval = 20;
            this.timeStart.Tick += new System.EventHandler(this.timeStart_Tick);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(262, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 16;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // ptcTwitter
            // 
            this.ptcTwitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptcTwitter.BackgroundImage")));
            this.ptcTwitter.Location = new System.Drawing.Point(183, 360);
            this.ptcTwitter.Name = "ptcTwitter";
            this.ptcTwitter.Size = new System.Drawing.Size(48, 48);
            this.ptcTwitter.TabIndex = 13;
            this.ptcTwitter.TabStop = false;
            // 
            // ptcGoogle
            // 
            this.ptcGoogle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptcGoogle.BackgroundImage")));
            this.ptcGoogle.Location = new System.Drawing.Point(116, 360);
            this.ptcGoogle.Name = "ptcGoogle";
            this.ptcGoogle.Size = new System.Drawing.Size(48, 48);
            this.ptcGoogle.TabIndex = 12;
            this.ptcGoogle.TabStop = false;
            // 
            // ptcFacebook
            // 
            this.ptcFacebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptcFacebook.BackgroundImage")));
            this.ptcFacebook.Location = new System.Drawing.Point(50, 360);
            this.ptcFacebook.Name = "ptcFacebook";
            this.ptcFacebook.Size = new System.Drawing.Size(48, 48);
            this.ptcFacebook.TabIndex = 11;
            this.ptcFacebook.TabStop = false;
            // 
            // ptcPassword
            // 
            this.ptcPassword.BackgroundImage = global::QuizApp.Properties.Resources.unlock;
            this.ptcPassword.Location = new System.Drawing.Point(50, 191);
            this.ptcPassword.Margin = new System.Windows.Forms.Padding(2);
            this.ptcPassword.Name = "ptcPassword";
            this.ptcPassword.Size = new System.Drawing.Size(24, 24);
            this.ptcPassword.TabIndex = 4;
            this.ptcPassword.TabStop = false;
            // 
            // ptcUsername
            // 
            this.ptcUsername.BackgroundImage = global::QuizApp.Properties.Resources.user1;
            this.ptcUsername.Location = new System.Drawing.Point(50, 126);
            this.ptcUsername.Margin = new System.Windows.Forms.Padding(2);
            this.ptcUsername.Name = "ptcUsername";
            this.ptcUsername.Size = new System.Drawing.Size(24, 24);
            this.ptcUsername.TabIndex = 1;
            this.ptcUsername.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this.pictureBox1;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(294, 454);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ptcTwitter);
            this.Controls.Add(this.ptcGoogle);
            this.Controls.Add(this.ptcFacebook);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.ptcPassword);
            this.Controls.Add(this.ptcUsername);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcGoogle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptcUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox ptcPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox ptcFacebook;
        private System.Windows.Forms.PictureBox ptcGoogle;
        private System.Windows.Forms.PictureBox ptcTwitter;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.Timer timeStart;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

