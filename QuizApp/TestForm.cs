using Bunifu.Framework.UI;
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
    public partial class TestForm : Form
    {
        DisplayQuestion displayQuestion1 = new QuizApp.DisplayQuestion();
        public TestForm()
        {
            InitializeComponent();
        }
        private void SetPanel(Control control)
        {
            panel1.Controls.Add(control);
        }
        private void setDataGridview(string exName)
        {
            string query = string.Format("select * from questions join exams on ex_id= q_fk_ex "+exName);
            using(DataTable table = new DataTable())
            {
                ReturnClass.FillAdapter(query, table);
                GridView.DataSource = table;
            }
        }
        private void setDataCbxNameExams()
        {
            string query = string.Format("select exam_name from exams");
            using(SqlDataReader reader = ReturnClass.readerReturn(query))
            {
                while(reader.Read())
                {
                    string content = reader.GetString(0);
                    //MessageBox.Show(content);
                    comboBox1.Items.Add(content);
                }
                
            }
            //comboBox1.Items
        }
        private void TestForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            setDataGridview("");
            setDataCbxNameExams();
            
            //displayQuestion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            //displayQuestion1.Dock = System.Windows.Forms.DockStyle.Fill;
            //displayQuestion1.Location = new System.Drawing.Point(0, 0);
            //displayQuestion1.Size = new System.Drawing.Size(679, 575);


            //SetPanel(displayQuestion1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDataGridview("where exam_name = N'" + comboBox1.SelectedItem.ToString() + "'");
        }
    }
}
