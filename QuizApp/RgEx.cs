using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    class RgEx
    {
        private static bool isNonCharSpecial(string input)
        {
            bool isReSult = new Regex(@"^[\w\s]{" + (input.Length) + "}").IsMatch(input);
            return isReSult;
        }
        private static bool isAlphanumericNotSpace(string input)
        {
            Regex regex = new Regex(@"^[a-zA-Z1-9]{1}([\w]{" + (input.Length - 1) + "})");
            return regex.IsMatch(input);
        }
        public static bool isAlphanumericNotSpace(string input,string aliases)
        {
            if (isEmpty(input,aliases)) { return false; }
            if (!isAlphanumericNotSpace(input)) {
                MessBox.MessError(string.Format("{0} cannot contain Scpace,Specia character!!!", aliases));
                return false;
            }
            return true;
        }
        public static bool isNonCharSpecialAndNonEmpty(string input,string aliases)
        {
            if (isEmpty(input, aliases)) { return false;
            {
                MessBox.MessError(string.Format("{0} cannot contain Specia character !!!", aliases)); }
            if (!isNonCharSpecial(input))
                return false;
            }
            return true;
        }
        public static string isNullOrEmpty(string str)
        {
            if (string.IsNullOrEmpty(str)) return "NULL";
            else return str;
        }
        public static bool isEmpty(string inp)
        {
            bool isEmpty = (inp.Length == 0) ? true :  false;
            
            return isEmpty;
        }
        public static bool isEmpty(string inp, string aliases)
        {
            if (isEmpty(inp)) { MessBox.MessError(aliases + " cannot be Empty !!!"); return true; }
            return false;
        }

    }
}
