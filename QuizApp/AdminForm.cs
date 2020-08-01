using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class AdminForm : Form
    {
        Dashboard dashboard;

        AddExam addExam;
        AddQuestions addQuestions;
        DisplayQuestion changeQues;
        ChangeExam changeExams;

        AddUsers addUserForm;
        ChangeUser changeUser;

        
        public AdminForm()
        {
            InitializeComponent();
        }
        public void HidePanel()
        {
            panelExams.Visible = false;
            panelQuestion.Visible = false;
            panelUser.Visible = false;
        }
        public void ShowSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                HidePanel();
                panel.Visible = true;
            }
            else panel.Visible = false;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            WaitAdminForm wait = new WaitAdminForm();
            wait.Show();
            this.KeyPreview = true;

            HidePanel();
            this.eclipse.ApplyElipse(panel1, 40);
            this.eclipse.ApplyElipse(panelMenu, 20);
            panel14.AutoScroll = true;

            dashboard = new Dashboard();
            SetControl(dashboard);OpenChillForm(dashboard);

            addQuestions = new AddQuestions();
            SetControl(addQuestions);OpenChillForm(addQuestions);

            changeQues = new DisplayQuestion();
            SetControl(changeQues); OpenChillForm(changeQues);

            changeUser = new ChangeUser();
            SetControl(changeUser); OpenChillForm(changeUser);

            addUserForm = new AddUsers();
            SetControl(addUserForm);OpenChillForm(addUserForm);

            addExam = new AddExam();
            SetControl(addExam); OpenChillForm(addExam);

            changeExams = new ChangeExam();
            SetControl(changeExams); OpenChillForm(changeExams);
            wait.Close();
            timer1.Start();
        }
        private void SetControl(Control control)
        {
            control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            control.Dock = System.Windows.Forms.DockStyle.Fill;
            control.Location = new System.Drawing.Point(0, 0);
            control.Size = new System.Drawing.Size(679, 575);
        }
        public void RefreshPnMove(Button bt)
        {
            pnMove.Top = bt.Top;
        }
        public void RefreshPnMove(int position)
        {
            pnMove.Location = new Point(pnMove.Location.X,position);
        }
        // When you clicked Button Power application is exit
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        /* Handle add UserControl into panelContent in middle of the Screen*/
        private void OpenChillForm(Control control)
        {
            panel14.Controls.Add(control);
        }

        //Set Green Panel show into top Chill Button
        private void SetCurrentControl(Control control)
        {
            panel14.Controls.SetChildIndex(control, 0);
        }

        //Click chill Control and display UserControl Coresponding to the function
        // Then Move panelMove using display clicked Control
        private void btnChildControl_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            switch (bt.Name)
            {
                case "btnDashboard":
                    SetCurrentControl(dashboard);
                    dashboard.GetDataUser();
                    RefreshPnMove(bt.Location.Y);
                    break;
                case "btnAddQuestions":
                    SetCurrentControl(addQuestions);
                    addQuestions.Clear();
                    RefreshPnMove(panelQuestion.Location.Y + bt.Location.Y);
                    break;
                case "btnChangeQuestion":
                    SetCurrentControl(changeQues);
                    changeQues.RefreshForm();
                    RefreshPnMove(panelQuestion.Location.Y + bt.Location.Y);
                    break;
                case "btnAddExams":
                    SetCurrentControl(addExam);
                    addExam.RefeshForm();
                    RefreshPnMove(panelExams.Location.Y + bt.Location.Y);
                    break;
                case "btnChangeEx":
                    SetCurrentControl(changeExams);
                    RefreshPnMove(panelExams.Location.Y + bt.Location.Y);
                    changeExams.InitEx();
                    break;
                case "btnAddUser":
                    SetCurrentControl(addUserForm);
                    RefreshPnMove(panelUser.Location.Y + bt.Location.Y);
                    addUserForm.Clear();
                    break;
                case "btnUserChange":
                    SetCurrentControl(changeUser);
                    RefreshPnMove(panelUser.Location.Y + bt.Location.Y);
                    changeUser.Clear();
                    break;
            };
        }
         /*
         handle events Clicked Button func and
         * display panel each clicked func
         */
        private void btnFunc_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            switch (bt.Name)
            {
                case "btnExams":
                    ShowSubMenu(panelExams);
                    RefreshPnMove(bt);
                    break;
                case "btnUser":
                    ShowSubMenu(panelUser);
                    RefreshPnMove(bt);
                    break;
                case "btnQuestion":
                    ShowSubMenu(panelQuestion);
                    RefreshPnMove(bt);
                    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminForm_Enter(object sender, EventArgs e)
        {
            
        }

        private void AdminForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt ==true && e.KeyCode == Keys.F4)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
        }
    }
}
