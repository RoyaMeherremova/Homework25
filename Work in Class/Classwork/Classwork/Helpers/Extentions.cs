using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classwork.Helpers
{
    internal static class Extentions
    {
        public static int GetNum(this int num)
        {
            return num;
        }


        public static bool CheckDigitInString(this string text)
        {

            return Regex.IsMatch(text, @"\d");

        }

        public static bool CheckString(this string text, string pattren)
        {
            return Regex.IsMatch(text, pattren);

        }

    }
}
