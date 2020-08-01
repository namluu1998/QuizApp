using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class HandleGrView
    {
        public static DataTable GetDataSource(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                ReturnClass.FillAdapter(query, dt);
                return dt;
            }catch
            {
                return null;
            }
        }
        public static void FilterDataTable(DataTable dt,string filter)
        {
            try
            {
                dt.DefaultView.RowFilter = filter;
            }catch
            {

            }
        }
    }
}
