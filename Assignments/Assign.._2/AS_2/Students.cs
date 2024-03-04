using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As_2_1_
{

    class Students
    {
        static string Stu_Name;
        static int Roll_no;
        static int Class;
        static string Semester;
        static string Branch;
        static int[] marks = new int[5];
        static void details()
        {
            Console.WriteLine("Fill all details:- ");
            Console.WriteLine("Enter the name of the Student:- ");
            Stu_Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Roll no.:- ");
            Roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Semester:- ");
            Semester = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Branch:- ");
            Branch = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Class:- ");
            Class = Convert.ToInt32(Console.ReadLine());

        }
        Students()
        {
            Console.WriteLine("\t\t\t\t\t\tName:- " + Stu_Name);
            Console.WriteLine("\t\t\t\t\t\tRoll no.:- " + Roll_no);
            Console.WriteLine("\t\t\t\t\t\tClass:- " + Class);
            Console.WriteLine("\t\t\t\t\t\tSemester:- " + Semester);
            Console.WriteLine("\t\t\t\t\t\tBranch:- " + Branch);
        }
        static void GetMarks()
        {
            Console.WriteLine("Enter the Marks of 5 subjects:- ");
            for(int i=0; i<marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static int total = 0;
    
        static void displayresult()
        {

            for(int i=0; i<marks.Length; i++)
            {
                total+=marks[i];
            }
            Console.WriteLine("Total Marks:- " + total);
            int avg = total / 5;
            Console.WriteLine("Average of Total Marks:- " + avg);
            Console.Write("Result Status:- ");
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    Console.Write("Failed");
                    break;
                }
                if(marks[i]>35 && avg<50)
                {
                    Console.Write("Failed");
                    break;
                }
                else
                {
                    Console.WriteLine("Passed");
                    break;
                }
            }
               


        }
        static void DisplayData()
        {
            Console.WriteLine("Name:- " + Stu_Name);
            Console.WriteLine("Roll no.:- " + Roll_no);
            Console.WriteLine("Class:- " + Class);
            Console.WriteLine("Semester:- " + Semester);
            Console.WriteLine("Branch:- " + Branch);
        }
        static void Main(String[] args)
        {
            details();
            Students st = new Students();
            Console.WriteLine();
            GetMarks();
            displayresult();
            Console.WriteLine("To display data press 'Y' otherwise press 'N':- ");
            char key = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");
            switch(key)
            {
                case char s when(key=='Y' || key=='y'):
                    DisplayData();
                    break;
                case char s when (key == 'N' || key == 'n'):
                    Console.Write("You can Exiyt now..");
                    break;
                default:
                    Console.Write("Invalid Input");
                    break;

            }
            Console.ReadLine();

        }
    }
}

