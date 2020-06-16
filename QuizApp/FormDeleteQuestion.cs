using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class FormDeleteQuestion : Form
    {
        public FormDeleteQuestion()
        {
            InitializeComponent();
            this.questionsTableAdapter.Fill(this.quizappDataSet1.questions);
            FormDeleteQuestion_Load(null, null);
        }

        private void FormDeleteQuestion_Load(object sender, EventArgs e)
        {
            string query = "select q_title,q_opa,q_opb,q_opc,q_opd,q_opcorrect,ad_user,exam_name from questions join admin_athu on admin_athu.ad_id = questions.q_fk_ad join exams on exams.ex_id = questions.q_fk_ex";
            dtGridDel.DataSource=ReturnClass.FillAdapter(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.questionsTableAdapter.FillBy(this.quizappDataSet1.questions);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
