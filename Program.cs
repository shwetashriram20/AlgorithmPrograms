namespace Day16_17
{

    public class Program
    {
        public static void Main(string[] args)
        {

            //String str = "SHW";
            //int n = str.Length;
            //Console.Write("\nAll possible strings are : ");
            //Iterative.IterativeMethod(str, 0, n - 1);

            // String s = "ABC";
            // String answer = "";

            // Console.Write("\nAll possible strings are : ");
            // Recursive.RecursiveMethod(s, answer);
            PalindromAnagram obja = new PalindromAnagram();
            obja.prime(2, 1000);
            obja.checkpal();
            obja.checkAnagram();



        }

    }

}








