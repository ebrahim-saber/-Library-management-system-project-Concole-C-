using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system
{
    internal class Librarian:User
    {
        public int EmployeeNumber { get; set; }

      public Librarian(string name)
        {
            Name = name;
        }
        public void AddBook(Book newBook , Library library)
        {
            //Add logic
            library.Add(newBook); //Assosiation
        }
        public void RemoveBook(Book newBook, Library library)
        {
            //Add logic
            library.Remove(newBook);
        }
    }
}
