using System;
using System.Text.RegularExpressions;

namespace day16
{
    class RegexStringFun
    {
        public static string Reg_pattern1 = "^[a-zA-Z]+$";
        public static string Reg_pattern2 = "^[a-zA-Z]+[' ']{1}[a-zA-Z]+$";
        public static string Reg_pattern3 = "^[0-9]{10}$";
        public static string Reg_pattern4 = "^[0-9]{2}[/]{1}[0-9]{2}[/]{1}[0-9]{4}$";
        public static void Main(String[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter your full name");
            string fname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter your mobile number");
            string mb = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter date in formate dd/mm/yyyy");
            string dt = Console.ReadLine();
            Console.WriteLine();



            bool val1 = Regex.IsMatch(name, Reg_pattern1);
            bool val2 = Regex.IsMatch(fname, Reg_pattern2);
            bool val3 = Regex.IsMatch(mb, Reg_pattern3);
            bool val4 = Regex.IsMatch(dt, Reg_pattern4);




            if (val1)
            {
                Console.WriteLine("Hello {0},We have your fullname as {1} in our system. your contact number is 91-{2}.\r\n" +
                        "Please,let us know in case of any clarification Thank you BridgeLabz {3}.", name, fname, mb, dt);
            }
            else
                Console.WriteLine("pattern is wrong");

        }
    }
}