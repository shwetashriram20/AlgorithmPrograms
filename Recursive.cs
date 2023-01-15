using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17
{
    public class Recursive
    {
        public static void RecursiveMethod(String str, String answer)
        {
            if (str.Length == 0)
            {
                Console.Write(answer + "  ");
                return;
            }

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                String left_substr = str.Substring(0, i);
                String right_substr = str.Substring(i + 1);
                String rest = left_substr + right_substr;
                RecursiveMethod(rest, answer + ch);
            }
        }
    }
}