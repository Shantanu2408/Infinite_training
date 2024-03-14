using System;
using System.IO;
using System.Text;
namespace Append_Text
{
    class AppendText
    {
        static void Main(string [] args)
        {
            string filePath = @"Aptest.txt";
            string textToAppend = "Hello, My name is Shantanu From Uttar Pradesh";
            try
            {
                using (StreamWriter write = new StreamWriter(filePath, true))
                {
                    write.WriteLine(textToAppend);
                }
                Console.WriteLine("Text Appended.....");
            }

             catch(Exception e)
            {
                Console.WriteLine($"Error {e.Message}");
            }
              Console.ReadLine();
        }
    }
}
