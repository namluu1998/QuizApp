using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace QuizApp
{
    class InsertClass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["quiz"].ConnectionString;

        public string insertQuestion(Questions question)
        {
            string msg = "";
            SqlConnection sqlConnection = new SqlConnection(connstring);
            sqlConnection.Open();
            try
            {
                
                SqlCommand sqlCommand = new SqlCommand("[insertQuestion]", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@q_title", SqlDbType.NVarChar).Value = question.q_title;
                
                sqlCommand.Parameters.Add("@q_opa", SqlDbType.NVarChar).Value = question.q_opa;
                sqlCommand.Parameters.Add("@q_opb", SqlDbType.NVarChar).Value = question.q_opb;
                sqlCommand.Parameters.Add("@q_opc", SqlDbType.NVarChar).Value = question.q_opc;
                sqlCommand.Parameters.Add("@q_opd", SqlDbType.NVarChar).Value = question.q_opd;
                sqlCommand.Parameters.Add("@q_opcorrect", SqlDbType.NVarChar).Value = question.q_opcorrect;

                sqlCommand.Parameters.Add("@q_addeddate", SqlDbType.NVarChar).Value = question.q_addeddate;
                sqlCommand.Parameters.Add("@q_fk_ad", SqlDbType.Int).Value = question.q_fk_ad;
                sqlCommand.Parameters.Add("@q_fk_ex", SqlDbType.Int).Value = question.q_fk_ex;
                sqlCommand.ExecuteNonQuery();
                msg = "Data Successfully Inserted";
            }catch(Exception)
            {
                msg = "Data Is Not Successfully Inserted";
            }
            finally
            {
                sqlConnection.Close();
            }
            return msg;
        }
    }
}
