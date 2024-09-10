using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to libirary system ");
            Library library = new Library();
            Console.Write("Welcom are u librarian or regular (L / R) : ");
            char userType = Console.ReadLine().ToUpper()[0];


            if (userType == 'L')
            {
                Console.Write("Welcome librarian , Enter ur name : ");
                string librarianName = Console.ReadLine();
                Librarian l1 = new Librarian(librarianName);
                Console.WriteLine($"Wlcome {l1.Name}");

                while (true)
                {
                    Console.Write("Please chose to Add book (A) , Remove book (R) , Display books (D) : ");
                    char choise = Console.ReadLine().ToUpper()[0];
                    switch (choise)
                    {
                        case 'A':
                            Console.WriteLine("Enter book details : ");
                            Console.Write("Title : ");
                            string bookTitle = Console.ReadLine();
                            Console.Write("Author : ");
                            string bookAuthor = Console.ReadLine();
                            Console.Write("Year : ");
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book() // obj initalizer
                            {
                                Title = bookTitle,
                                Author = bookAuthor,
                                Year = bookYear
                            };

                            l1.AddBook(book, library);
                            break;
                        case 'R':
                            Console.WriteLine("Enter book details to remove : ");
                            Console.Write("Title : ");
                            bookTitle = Console.ReadLine();
                            Console.Write("Author : ");
                            bookAuthor = Console.ReadLine();
                            Console.Write("Year : ");
                            bookYear = Convert.ToInt32(Console.ReadLine());
                            book = new Book() // obj initalizer
                            {
                                Title = bookTitle,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            l1.RemoveBook(book, library);
                            break;
                        case 'D':
                            Console.WriteLine("Display books :  ");
                            l1.DisplayBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }

            else if (userType == 'R')
            {
                Console.Write("Welcome User , Enter ur name : ");
                string name = Console.ReadLine();
                LibraryUser u1 = new LibraryUser(name);
                Console.WriteLine($"Wlcome {u1.Name}");

                Console.Write("Please chose to Add book (A) , Remove book (R) , Display books (D) : ");
                char choise = Console.ReadLine().ToUpper()[0];

                while (true)
                {
                    Console.Write("Please chose to Borrow book (B) , Display books (D) : ");
                    char choiseuser = Console.ReadLine().ToUpper()[0];
                    switch (choiseuser)
                    {
                        case 'B':
                            Console.WriteLine("Enter book details to borrow: ");
                            Console.Write("Title : ");
                            string bookTitle = Console.ReadLine();
                            Console.Write("Author : ");
                            string bookAuthor = Console.ReadLine();
                            Console.Write("Year : ");
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book() // obj initalizer
                            {
                                Title = bookTitle,
                                Author = bookAuthor,
                                Year = bookYear
                            };

                            u1.BorrowBooks(book, library);
                            break;
                        case 'D':
                            Console.WriteLine("Display books :  ");
                            u1.DisplayBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }

            else
            {
                Console.WriteLine("Enter correct value (L or R)");
            } 

        }
    }
}
