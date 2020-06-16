namespace QuizApp
{
    partial class FormDeleteQuestion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizappDataSet1 = new QuizApp.quizappDataSet1();
            this.questionsTableAdapter = new QuizApp.quizappDataSet1TableAdapters.questionsTableAdapter();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblOpA = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblOpB = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblOpC = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblOPD = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge3 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge4 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge5 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge6 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge7 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizappDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuDropdown1);
            this.panel1.Controls.Add(this.kryptonBorderEdge7);
            this.panel1.Controls.Add(this.kryptonBorderEdge6);
            this.panel1.Controls.Add(this.kryptonBorderEdge5);
            this.panel1.Controls.Add(this.kryptonBorderEdge4);
            this.panel1.Controls.Add(this.kryptonBorderEdge3);
            this.panel1.Controls.Add(this.kryptonBorderEdge2);
            this.panel1.Controls.Add(this.kryptonBorderEdge1);
            this.panel1.Controls.Add(this.bunifuCustomLabel14);
            this.panel1.Controls.Add(this.bunifuCustomLabel13);
            this.panel1.Controls.Add(this.bunifuCustomLabel12);
            this.panel1.Controls.Add(this.bunifuCustomLabel11);
            this.panel1.Controls.Add(this.lblOPD);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.lblOpC);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.lblOpB);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.lblOpA);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 447);
            this.panel1.TabIndex = 0;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "questions";
            this.questionsBindingSource.DataSource = this.quizappDataSet1;
            // 
            // quizappDataSet1
            // 
            this.quizappDataSet1.DataSetName = "quizappDataSet1";
            this.quizappDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 72);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(43, 20);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Title :";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTitle.Location = new System.Drawing.Point(153, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(432, 66);
            this.lblTitle.TabIndex = 1;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(12, 147);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(82, 20);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "Option A :";
            // 
            // lblOpA
            // 
            this.lblOpA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpA.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblOpA.Location = new System.Drawing.Point(121, 147);
            this.lblOpA.Name = "lblOpA";
            this.lblOpA.Size = new System.Drawing.Size(508, 43);
            this.lblOpA.TabIndex = 1;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 199);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(80, 20);
            this.bunifuCustomLabel5.TabIndex = 1;
            this.bunifuCustomLabel5.Text = "Option B :";
            // 
            // lblOpB
            // 
            this.lblOpB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpB.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblOpB.Location = new System.Drawing.Point(121, 199);
            this.lblOpB.Name = "lblOpB";
            this.lblOpB.Size = new System.Drawing.Size(508, 43);
            this.lblOpB.TabIndex = 1;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(12, 242);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(83, 20);
            this.bunifuCustomLabel7.TabIndex = 1;
            this.bunifuCustomLabel7.Text = "Option C :";
            // 
            // lblOpC
            // 
            this.lblOpC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpC.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblOpC.Location = new System.Drawing.Point(121, 242);
            this.lblOpC.Name = "lblOpC";
            this.lblOpC.Size = new System.Drawing.Size(508, 43);
            this.lblOpC.TabIndex = 1;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(12, 285);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(82, 20);
            this.bunifuCustomLabel9.TabIndex = 1;
            this.bunifuCustomLabel9.Text = "Option D :";
            // 
            // lblOPD
            // 
            this.lblOPD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPD.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblOPD.Location = new System.Drawing.Point(121, 285);
            this.lblOPD.Name = "lblOPD";
            this.lblOPD.Size = new System.Drawing.Size(508, 43);
            this.lblOPD.TabIndex = 1;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(12, 328);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(108, 20);
            this.bunifuCustomLabel11.TabIndex = 1;
            this.bunifuCustomLabel11.Text = "People Add : ";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(121, 328);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(508, 43);
            this.bunifuCustomLabel12.TabIndex = 1;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(12, 371);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(83, 43);
            this.bunifuCustomLabel13.TabIndex = 1;
            this.bunifuCustomLabel13.Text = "Kind Of Question :";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(121, 371);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(508, 43);
            this.bunifuCustomLabel14.TabIndex = 1;
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(121, 137);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(527, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonBorderEdge2
            // 
            this.kryptonBorderEdge2.Location = new System.Drawing.Point(121, 199);
            this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            this.kryptonBorderEdge2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonBorderEdge2.Size = new System.Drawing.Size(527, 1);
            this.kryptonBorderEdge2.Text = "kryptonBorderEdge1";
            // 
            // kryptonBorderEdge3
            // 
            this.kryptonBorderEdge3.Location = new System.Drawing.Point(118, 242);
            this.kryptonBorderEdge3.Name = "kryptonBorderEdge3";
            this.kryptonBorderEdge3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonBorderEdge3.Size = new System.Drawing.Size(527, 1);
            this.kryptonBorderEdge3.Text = "kryptonBorderEdge1";
            // 
            // kryptonBorderEdge4
            // 
            this.kryptonBorderEdge4.Location = new System.Drawing.Point(121, 284);
            this.kryptonBorderEdge4.Name = "kryptonBorderEdge4";
            this.kryptonBorderEdge4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonBorderEdge4.Size = new System.Drawing.Size(527, 1);
            this.kryptonBorderEdge4.Text = "kryptonBorderEdge1";
            // 
            // kryptonBorderEdge5
            // 
            this.kryptonBorderEdge5.Location = new System.Drawing.Point(121, 324);
            this.kryptonBorderEdge5.Name = "kryptonBorderEdge5";
            this.kryptonBorderEdge5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonBorderEdge5.Size = new System.Drawing.Size(527, 1);
            this.kryptonBorderEdge5.Text = "kryptonBorderEdge1";
            // 
            // kryptonBorderEdge6
            // 
            this.kryptonBorderEdge6.Location = new System.Drawing.Point(118, 370);
            this.kryptonBorderEdge6.Name = "kryptonBorderEdge6";
            this.kryptonBorderEdge6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonBorderEdge6.Size = new System.Drawing.Size(527, 1);
            this.kryptonBorderEdge6.Text = "kryptonBorderEdge1";
            // 
            // kryptonBorderEdge7
            // 
            this.kryptonBorderEdge7.Location = new System.Drawing.Point(118, 413);
            this.kryptonBorderEdge7.Name = "kryptonBorderEdge7";
            this.kryptonBorderEdge7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonBorderEdge7.Size = new System.Drawing.Size(527, 1);
            this.kryptonBorderEdge7.Text = "kryptonBorderEdge1";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(15, 12);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(633, 35);
            this.bunifuDropdown1.TabIndex = 9;
            // 
            // FormDeleteQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(657, 447);
            this.Controls.Add(this.panel1);
            this.Name = "FormDeleteQuestion";
            this.Text = "FormDeleteQuestion";
            this.Load += new System.EventHandler(this.FormDeleteQuestion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizappDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        private quizappDataSet1 quizappDataSet1;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private quizappDataSet1TableAdapters.questionsTableAdapter questionsTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge7;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge6;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge5;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge4;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge3;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOPD;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOpC;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOpB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOpA;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
    }
}