using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign._5
{
    public class Books
    {
        string Book_Name;
        string Author_Name;
         public Books(string Book_Name, string Author_Name)
        {
            this.Book_Name = Book_Name;
            this.Author_Name = Author_Name;
        }
        
        
            public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return Book_Name;
                }
                else if (index == 1)
                {
                    return Author_Name;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index == 0)
                {
                    Book_Name = (string)value;
                }
                else if (index == 1)
                {
                    Author_Name = (string)value;
                }

            }
        }
        }
        
    }

