using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system
{
    internal class Library
    {
        private Book[] books = new Book[100]; //maxmum capacity of books = 100
        private int currentBookCount = 0;
        private Book[] BorrwedBook = new Book[50];
        private int currentBorrwedBookCount = 0;


        public void Display()
        {
            //Add logic
            //foreach (var book in books)  //it will take 100 loop to each array of element 
            //{
            //    Console.WriteLine($"Book Title : {book.Title}");
            //    Console.WriteLine($"Book Author : {book.Author}");
            //    Console.WriteLine($"Book Year : {book.Year}");
            //}

            for (int i = 0; i < currentBookCount; i++)
            {
                //Console.WriteLine(books[i].Title);
                Console.WriteLine($"Book Title : {books[i].Title}");
                Console.WriteLine($"Book Author : {books[i].Author}");
                Console.WriteLine($"Book Year : {books[i].Year}");
            }
        }
        public void Add(Book book)
        {

            if (currentBookCount < books.Length)
            {
                books[currentBookCount] = book; //To Add new book into array
                currentBookCount++;
                Console.WriteLine("Book added succesfuly");

            }
            else
            {
                Console.WriteLine("Current library is full , Can't Add new book for now ");
            }

        }
        public void Remove(Book book)
        {
            //Add logic
            int index = Array.IndexOf(books, book);
           books[index] = null;
            currentBookCount--;
            Console.WriteLine("Book Removed succesfuly");
        }
        public void BorrowBook(Book book) 
        {
            if (currentBorrwedBookCount < BorrwedBook.Length)
            {
                BorrwedBook[currentBorrwedBookCount] = book; //To Add new book into array
                currentBorrwedBookCount++;
                Console.WriteLine("Book borrow succesfuly");

            }
            else
            {
                Console.WriteLine("sorry u cant borrw any booy fo now!! ");
            }
        }
    }
}
