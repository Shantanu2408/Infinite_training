using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        int Produc_tId;
        string Product_Name;
        int price;

        public static void SortedListFunction()
        {
            SortedList sr = new SortedList();  


            sr.Add(190, "Pencil");
            sr.Add(80, "Pen");
            sr.Add(70, "Apple");
            sr.Add(85, "Orange");
            sr.Add(70, "Mixer");
            sr.Add(190, "Medicine");
            sr.Add(230, "Dry Fruits");
            sr.Add(84, "Umbrella");
            sr.Add(90, "Lichi");
            sr.Add(48, "Papaya");
            Console.WriteLine("------Sorted List-------");
            foreach (DictionaryEntry st in sr)
            {
                Console.WriteLine("" + st.Key + " " + st.Value);
                Console.WriteLine();
            }

        }
    }
}