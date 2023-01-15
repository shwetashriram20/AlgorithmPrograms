namespace SortingTechniques
{

    public class Program
    {
        public static void Main(string[] args)
        {

            //String str = "SHW";
            //int n = str.Length;
            //Console.Write("\nAll possible strings are : ");
            //Iterative.IterativeMethod(str, 0, n - 1);
            
            String s = "ABC";
            String answer = "";

            Console.Write("\nAll possible strings are : ");
            Recursive.RecursiveMethod(s, answer);



        }

    }

}


