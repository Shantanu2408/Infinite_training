using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Text
{
    public delegate int Calculator_Func(int x, int y);
        
    class Calculator
    {
        static int Addition(int a , int b)
        {
            return a + b;
        }
        static int Substract(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static void Main(string [] args)
        {
            Calculator_Func Add = new Calculator_Func(Addition);
            Calculator_Func sub = new Calculator_Func(Substract);
            Calculator_Func Multiply = new Calculator_Func(Mul);

            // Take input from the user....
            Console.Write("Enter the value of a:-");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b:-");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Print all values
            Console.WriteLine($"Addition of {a} and {b} = {Add(a, b)}");
            Console.WriteLine($"Substraction of {a} and {b} = {sub(a, b)}");
            Console.WriteLine($"Multiplication of {a} and {b} = {Multiply(a, b)}");
            Console.ReadLine();
        }
    }
}
