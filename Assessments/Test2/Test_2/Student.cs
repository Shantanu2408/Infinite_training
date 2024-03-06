using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public abstract bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("----- Abstract class called  Student with  Name, StudentId, Grade as members -----");


            Undergraduate undergradStudent = new Undergraduate
            {
                Name = "Shantanu Singh",
                StudentId = 1034313,
                Grade = 81.0
            };


            Console.WriteLine($"Undergraduate Student: {undergradStudent.Name}, ID: {undergradStudent.StudentId}, Grade: {undergradStudent.Grade}");
            Console.WriteLine($"Is Passed: {undergradStudent.IsPassed(undergradStudent.Grade)}\n");

            Graduate gradStudent = new Graduate
            {
                Name = "Prashant Singh",
                StudentId = 9567898,
                Grade = 83.0
            };

            Console.WriteLine($"Graduate Student: {gradStudent.Name}, ID: {gradStudent.StudentId}, Grade: {gradStudent.Grade}");
            Console.WriteLine($"Is Passed: {gradStudent.IsPassed(gradStudent.Grade)}");
            Console.ReadLine();
        }
    }
}