using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class Program
    {
        public static string Stu_Name;
        protected static int Stu_Rn;
        internal static int Tl_ms;
        public static int sub;
        public static int[] arr;
        static void Main(string[] args)
        {
            print();
            Console.ReadLine();
        }
        static void PutData()
        {
            Console.WriteLine("Enter Student Name:- ");
            Stu_Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Student Roll no:- ");
            Stu_Rn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of the subjects:- ");
            sub = Convert.ToInt32(Console.ReadLine());
            arr = new int[sub];
            Console.WriteLine("Enter the Subjects Marks:-");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }

        }
        static void Getdata()
        {
            Console.WriteLine("Name:- " + Stu_Name);
            Console.WriteLine("Roll No:- " + Stu_Rn);
            Console.WriteLine("Marks:-> ");
            for (int i = 0; i < sub; i++)
            {
                Console.WriteLine((i + 1) + ":- " + arr[i]);
                Tl_ms += arr[i];
            }
            Console.WriteLine("Total_Marks:- " + Tl_ms);
            double pr = Convert.ToDouble((100 )* Tl_ms / (sub*100));
            Console.WriteLine("Percentage:- " + pr);
            

        }
        static void print()
        {
            PutData();
            Getdata();
        }
      /*  class trial : Program
        {
            trial tr = new trial();
          
        }*/
    }
}
