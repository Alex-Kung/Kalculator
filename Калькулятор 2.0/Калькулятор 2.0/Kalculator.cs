using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор_2._0
{
    public class Kalculator
    {
        public static string Count(double a, double b, char c)
        {
            string s="";
            if (c == '/')
            {
                if (b == 0)
                { s = (a / b).ToString();   Form1.NullExc();  }
                else
                s = (a / b).ToString();
            }
            if (c == '*') { s = (a * b).ToString(); }
            if (c == '+') { s = (a + b).ToString(); }
            if (c == '-') { s = (a - b).ToString(); }
            if (c == '^') { s = (Math.Pow(a, b).ToString()); }
            if (c == '%') { s = (a / 100 * b).ToString(); }
            if (c == '√') { s = Math.Sqrt(b).ToString(); }
            return s;
        }
    }
}
