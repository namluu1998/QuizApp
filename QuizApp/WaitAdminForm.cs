using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class WaitAdminForm : Form
    {
        public static WaitAdminForm wait;
        List<Color> colors = new List<Color>();
        int currentColor = 0;
        int a = 0;
        public WaitAdminForm()
        {
            colors.Add(Color.FromArgb(126, 165,192));
            colors.Add(Color.FromArgb(203, 205, 114));
            //colors.Add(Color.FromArgb(144, 107, 207));
            //colors.Add(Color.FromArgb(216, 155, 40));
            //colors.Add(Color.FromArgb(217, 102, 41));
            //colors.Add(Color.FromArgb(217, 102, 41));
            //colors.Add(Color.FromArgb(235, 83, 104));
            //colors.Add(Color.FromArgb(223, 128, 225));
            //colors.Add(Color.FromArgb(112, 48, 160));

            InitializeComponent();
        }
        private void color_OnValueChange(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (currentColor < colors.Count - 1)
            {
                this.BackColor = BunifuColorTransition.getColorScale(a, colors[currentColor], colors[currentColor + 1]);
                if (a < 100) a++;
                else
                {
                    a = 0;
                    currentColor++;
                }
                timer1.Enabled = true;
            }
        }

        private void WaitAdminForm_Load(object sender, EventArgs e)
        {
            eclipse.ApplyElipse(pictureBox1, 90);
            string query = string.Format("select Images from admin_athu where ad_user = '{0}'", FormLogin.username);
            string result = ReturnClass.scalarReturn(query);
            if (!string.IsNullOrEmpty(result)) pictureBox1.Image = Image.FromFile(result);

            txtName.Text = FormLogin.username + " Login";
            this.Opacity = 0.9;
            timer2.Start();
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch(btnDots.Text)
            {
                case ". . . ":
                    btnDots.Text = ". "; break;
                case ". . ":
                    btnDots.Text = ". . . "; break;
                case ". ":
                    btnDots.Text = ". . "; break;
            }
        }
    }
}
