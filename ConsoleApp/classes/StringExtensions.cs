using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.classes
{
    static class StringExtensions
    {
        public static string MyReverse(this string s)
        {
            string result = "";
            foreach (char c in s)
                result = c + result;
            return result;
        }
        public static int MyCount(this string s, char C)
        {
            int result = 0;
            foreach (char c in s)
                if (c == C)
                    result++;
            return result;
        }
    }
}
