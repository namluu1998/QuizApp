using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class DataReader
    {
        public static object GetDataReader(SqlDataReader reader,int i)
        {
            try
            {
                return reader.GetValue(i);
            }catch
            {
                return null;
            }
        }
        public static string getStringBitDb(string Checked)
        {
            return Checked.Equals("True") ? "1" : "0";
        }
        public static string getStringBitDb(bool Checked)
        {
            return Checked ? "1" : "0";
        }
        public static bool getBooleanInStringTF(string Checked)
        {
            return Checked.Equals("True") ? true : false;
        }
        public static bool getBooleanInStringBit(string str)
        {
            return str.Equals("0") ? false : true;
        }
    }
}
