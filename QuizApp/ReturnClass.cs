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
    class ReturnClass
    {
        public static string connstring = "Data Source=DESKTOP-1BL09M0;Initial Catalog=quizapp;User ID=admin;Password=123456";
        static SqlConnection sqlConnection = new SqlConnection(connstring);

        public enum Status
        {
            insert,
            delete,
            update
        }
        public static string scalarReturn(string q)
        {
            string s="";
            //Query Execution
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(q, sqlConnection);
                object ob = sqlCommand.ExecuteScalar();
                if (ob != null) s = ob.ToString();
            }
            catch(Exception ex){
                MessBox.MessError(ex.Message);
            }
            sqlConnection.Close();
            return s;
        }
        public static bool ExcuteNonQuery(string query)
        {
            bool Result = false;
            try
            {
                //Query Execution
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                Result = command.ExecuteNonQuery() ==0 ? false : true;
            }
            catch (Exception ex)
            {
                MessBox.MessError(ex.Message);
            }
            return Result;
        }
        public static void ExcuteNonQuery(string query, Status stt)
        {
            if (!ExcuteNonQuery(query)) return;

            string msg="";
            switch (stt)
            {
                case Status.insert:
                    msg = "Success Insert !!! ";
                    break;
                case Status.delete:
                    msg = "Success Delete !!! ";
                    break;
                case Status.update:
                    msg = "Success Update !!! ";
                    break;
            }
            MessBox.MessSuccess(msg);

        }
        public static SqlDataReader readerReturn(string q)
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
        public static void FillAdapter(string query,DataTable dt)
        {
            using (var con = new SqlConnection(connstring))
            {
                new SqlDataAdapter(query, con).Fill(dt);
            }
        }
    }

}
