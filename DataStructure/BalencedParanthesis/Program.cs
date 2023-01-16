namespace Stack
{
    using System;

    /// <summary>
    /// this is Program class for Stack operations.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("****************************Stack Operations*****************************");
            Console.WriteLine("Simple Balanced Parentheses :");

            BalanceParentheses check = new BalanceParentheses();
            check.IsBalanceParentheses();

        }
                
    }
}

