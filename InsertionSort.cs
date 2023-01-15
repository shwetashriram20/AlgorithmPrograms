using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class InsertionSort
    {
        public void Insertion_Sort()
        {
            int[] arr = new int[5] { 23, 9, 5, 12, 99 };
            int n = 5, i, j, val, flag;
            Console.WriteLine("Insertion Sorting");
            Console.WriteLine("initial array:");

            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                        flag = 1;
                }

            }
            Console.WriteLine("Sorted array:");
            for (i = 1; i < n; i++)
            {
                Console.WriteLine(arr[i]);

            }

        }
    }
}
