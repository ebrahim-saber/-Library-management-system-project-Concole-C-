using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system
{
    internal class LibraryUser:User
    {
        public LibraryUser(string name)
        {
            Name = name;
        }
        public LibraryCard card { get; set; }

       public void BorrowBooks(Book book , Library library)
        {
            //Add logic
            library.BorrowBook(book);
        }

    }
}
