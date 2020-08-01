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
    public partial class DisplayResultStartForm : Form
    {
        public DisplayResultStartForm()
        {
            InitializeComponent();
        }

        private void DisplayResultStartForm_Load(object sender, EventArgs e)
        {
            ResultDataQs dataQs = ResultDataQs.getInstance();
            dataQs.setPanelRoot(pnContent);
            //dataQs.InitQuestion();
            //dataQs.addPanelParentOption();
            //dataQs.addPanelQs();
        }

        private void lblDetail_Click(object sender, EventArgs e)
        {

        }

        private void ptcOp_Click(object sender, EventArgs e)
        {

        }
    }
}
