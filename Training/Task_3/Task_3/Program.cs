using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day4
{
    enum cities { Agra = 5, Hyderabd, delhi = 9, noida, Vizag };   // named constant
    struct Customer   // change struct to class
    {
        public int CustRating;          // we can not initilize here,
                                        //internal Customer(int crating)   // Constructor
                                        //{
                                        //    CustRating = crating;
                                        //}
                                        //public void giveCustRating()
                                        //{
                                        //    CustRating = 4;
                                        //}

    }
    class StructEnum
    {
        enum colors { red, blue, yellow, white, black };
        public static void StructTestClass()
        {
            // object of structure
            //Customer cust1;   //or
            Customer cust1 = new Customer();
            cust1.CustRating = 4;
            //Console.WriteLine(cust1.CustRating);
            Customer cust2 = new Customer();
            cust2 = cust1;   // 
            Console.WriteLine(cust1.CustRating + " " + cust2.CustRating);
            cust2.CustRating = 6;
            Console.WriteLine("After Changes-----");
            Console.WriteLine(cust1.CustRating + " " + cust2.CustRating);

        }
        public static void Enum_op()
        {
            foreach (int i in Enum.GetValues(typeof(cities)))
            {
                //Console.WriteLine(i);
                Console.WriteLine(Enum.GetName(typeof(cities), i));
            }
            Console.WriteLine("------------");
            foreach (string s in Enum.GetNames(typeof(cities)))
            {
                Console.WriteLine(s);
            }
        }
        public static void Main()
        {
            StructEnum.StructTestClass();
            StructEnum.Enum_op();
            Console.Read();

        }
    }
}