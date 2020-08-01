using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bunifu.Framework.UI;

namespace QuizApp
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1_Tick(null, null);
            GetDataUser();
        }
        private void setContentPanel(string content,Panel panel,BunifuCustomLabel label)
        {
            if (string.IsNullOrEmpty(content))
                panel.Visible = false;
            else
            {
                if (panel.Visible == false) panel.Visible = true;
                label.Text = content;
            }
        }
        public void GetDataUser()
        {
            /*Query Filter username in Login form into this Form*/
            string query = string.Format("select * from admin_athu where ad_user ='{0}'",FormLogin.username);
            using(SqlDataReader reader = ReturnClass.readerReturn(query))
                if(reader.Read())
                {
                    /*Username*/
                    setContentPanel(DataReader.GetDataReader(reader,0) as string, pnUsername, lblUsername);
                    /*Full Name*/
                    setContentPanel(DataReader.GetDataReader(reader, 3) as string, pnFullName, lblFullName);
                    ////Get object int then compare with null if true then parameter is Empty else string in obj
                    //object obj = DataReader.GetDataReader(reader, 4);
                    //setContentPanel(obj.Equals(null)?"":obj.ToString(), pnAge, lblAge);
                    /*Live*/
                    setContentPanel(DataReader.GetDataReader(reader, 4) as string, pnLive, lblLive);
                    //Get object Date then compare with null if true then parameter is Empty else cast object into DateTime and 
                    // Pass parameter is ToShotDateString method
                    object obj = DataReader.GetDataReader(reader, 5);
                    setContentPanel(obj.Equals(null) ? "" : ((DateTime)obj).ToShortDateString(), pnDateOfBirth, lblDateOfBirth);
                    /*Phone number*/
                    setContentPanel(DataReader.GetDataReader(reader, 6) as string, pnPhoneNum, lblPhoneNum);
                    obj = DataReader.GetDataReader(reader, 7);
                    pictureBox1.Image =  ((obj is System.DBNull || string.IsNullOrEmpty((string)obj))) ? Properties.Resources.businesswoman : Image.FromFile((string)obj);
                }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDayOfWeek.Text = DateTime.Now.DayOfWeek.ToString() + " " + DateTime.Now.ToShortTimeString();
        }
    }
}
