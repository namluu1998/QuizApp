using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    class MessBox
    {
        public static bool MessWarning(string title)
        {
            DialogResult result = MessageBox.Show(title, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return (result == DialogResult.Yes ? true : false);
        }
        public static void MessInf(string title)
        {
            AlertForm alertForm = new AlertForm();
            alertForm.showAlert(title, AlertForm.enmType.Info);
        }
        public static void Warning(string title)
        {
            AlertForm alertForm = new AlertForm();
            alertForm.showAlert(title, AlertForm.enmType.Warning);
        }
        public static void MessSuccess(string msg="Success !!!")
        {
            AlertForm alertForm = new AlertForm();
            alertForm.showAlert(msg, AlertForm.enmType.Success);
        }
        public static void MessError(string title)
        {
            AlertForm alertForm = new AlertForm();
            alertForm.showAlert(title, AlertForm.enmType.Error);
        }
    }
}
