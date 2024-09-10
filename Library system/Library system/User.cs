using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system
{
    internal abstract class User
    {
        public  string Name { get; set; }

        public void DisplayBooks(Library library)
        {
            //Add logic
            library.Display();
        }
    }
}
