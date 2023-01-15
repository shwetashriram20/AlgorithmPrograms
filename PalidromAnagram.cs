using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    public class PalindromAnagram
    {

        List<int> Arp = new List<int>();
        List<int> Anp = new List<int>();

        public int j, x, k, val, flag = 0;
        public void prime(int start, int end)
        {
            for (k = start; k <= end; k++)
            {
                if (k == 1 || k == 0)
                    continue;

                int count = 0;
                for (j = 2; j <= k / 2; j++)
                {
                    if (k % j == 0)
                    {
                        count = 1;
                        break;

                    }
                }

                if (count == 0)
                {
                    
                    Arp.Add(k);
                }


            }
        }
        public void checkpal()
        {
            Console.WriteLine("Palindrome prime numbers are: ");
            foreach (int d in Arp)
            {
                int c = d; ;
                int rev = 0;
                for (int e = 0; e != d; e++)
                {

                    int C = (c % 10);

                    rev = (rev * 10) + C;
                    c = (c / 10);
                    if (rev == d)
                    {
                        Anp.Add(rev);
                        Console.WriteLine(rev);
                    }
                }
            }
        }
        public void checkAnagram()
        {
            foreach (int f in Anp)
            {
                for (int i = 1; i < Anp.Count; i++)
                {
                    val = Anp[i];
                    for (j = i - 1; j >= 0 && flag != 1;)
                    {
                        if (val == Anp[j])
                        {
                            Console.WriteLine("anagram number " + j);
                        }
                        else
                        {
                            flag = 1;
                        }
                    }
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("anagram number not present in prime palindrome list");
            }


        }
    }

}
