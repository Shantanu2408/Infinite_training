using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Products
    {
        int Product_Id;
        string Product_Name;
        int price;

        public static void SortedListFunction()
        {
            SortedList s1 = new SortedList();  


            s1.Add(120, "Apple");
            s1.Add(80, "Grapes");
            s1.Add(59, "PineApple");
            s1.Add(89, "Apple");
            s1.Add(56, "Grapes");
            s1.Add(7, "PineApple");
            s1.Add(27, "Apple");
            s1.Add(12, "Grapes");
            s1.Add(30, "PineApple");
            s1.Add(82, "Banana");
            Console.WriteLine("------Sorted List-----");
            foreach (DictionaryEntry de in s1)
            {
                Console.WriteLine("" + de.Key + " " + de.Value);
                Console.WriteLine();
            }

        }
    }
}