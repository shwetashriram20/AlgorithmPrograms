using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class OrderedList
    {
        public void Ordered()
        {
            LinkList list = new LinkList();
            string text = File.ReadAllText(@"G:\net\LinkedList\LinkedList\inputNumber.txt", Encoding.UTF8);
            string[] stringSeparator = new string[] { " " };
            string[] textArray;
            textArray = text.Split(stringSeparator, StringSplitOptions.RemoveEmptyEntries);
            int[] textInteger = new int[textArray.Length];
            for (int i = 0; i < textArray.Length; i++)
            {
                textInteger[i] = Convert.ToInt32(textArray[i]);
            }
            for (int i = 0; i < textInteger.Length; i++)
            {
                Console.Write(textInteger[i] + " ");
            }
            for (int i = 0; i < textInteger.Length; i++)
            {
                list.InsertSorted(textInteger[i]);
            }
            list.DisplayIntList();
            Console.WriteLine("Enter a string which you want to be found:");
            int searchInt = Convert.ToInt32(Console.ReadLine());
            if (list.SearchInt(searchInt))
            {
                list.DeleteIntKeyElement(searchInt);
            }
            else
            {
                list.InsertSorted(searchInt);
            }
            list.DisplayIntList();
            string intString = list.ReturnNumberString();
            File.WriteAllText(@"G:\net\LinkedList\LinkedList\inputNumber.txt", intString);
        }
    }
}


