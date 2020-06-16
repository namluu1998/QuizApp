using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuizApp
{
    class ReturnClass
    {
        public static string connstring = ConfigurationManager.ConnectionStrings["quiz"].ConnectionString;
        string s;
        SqlConnection sqlConnection = new SqlConnection(connstring);
        public string scalarReturn(string q)
        {

            //Query Execution
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(q, sqlConnection);
                s = sqlCommand.ExecuteScalar().ToString();
            }catch(Exception)
            {
                s = " ";
            }
            sqlConnection.Close();
            return s;
        }
        public SqlDataReader readerReturn(string q)
        {
            if(sqlConnection.State==ConnectionState.Closed)
                sqlConnection.Open();
            SqlDataReader sqlDataReader;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(q, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch
            {
                sqlDataReader = null;
            }
            return sqlDataReader;
            //define Close in class SqlConnection Outside
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }
        public static DataTable FillAdapter(string query)
        {
            DataTable dt = new DataTable();
            using (var con = new SqlConnection(connstring))
            {
                new SqlDataAdapter(query, con).Fill(dt);
            }
            return dt;
        }

    }
}
