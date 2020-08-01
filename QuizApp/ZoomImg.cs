using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using Guna;

namespace QuizApp
{
    public partial class ZoomImg : UserControl
    {
        Image imgCurrent=null;
        public ZoomImg()
        {
            InitializeComponent();
        }

        private void ZoomImg_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        public void SetImage(string fileName)
        {
            Image img = Image.FromFile(fileName);
            if (img != imgCurrent)
            {
                    pictureBox1.Image=imgCurrent = img;
                    this.Visible = true;
            }
        }
        public void SetImage(object sender)
        {
            PictureBox img = sender as PictureBox;
            if (img.Image != imgCurrent)
            {
                    pictureBox1.Image=imgCurrent = img.Image;
                    this.Visible = true;
            }
        }
        public void SetImage(Image image)
        {
            if(imgCurrent != image)
            {
                pictureBox1.Image = imgCurrent = image;
                this.Visible = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (imgCurrent == null && this.Visible == true) {   }
            if (imgCurrent != pictureBox1.Image) pictureBox1.Image = imgCurrent;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Visible = false;
            imgCurrent = null;
        }
    }
}
