using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2__Hoàng_Việt_
{
    internal class LibrarySystem
    {
        public List<BookLibrary> bookList = new List<BookLibrary>();
        public void ListOfBook()
        {
            bookList.Add(new BookLibrary("Journey to the West", "Ngo Thua An", "Fantasy", 1986, 12, 10000));
            bookList.Add(new BookLibrary("Harry Potter", "J.K.Rowling", "Fantasy", 1997, 10, 25000));
            bookList.Add(new BookLibrary("How to win friends& influence people", "Dale Carnegie", "Education", 1936, 15, 15000));
            bookList.Add(new BookLibrary("The adventure of Cricket", "To Hoai", "Adventure", 1941, 9, 5000));
            bookList.Add(new BookLibrary("1984", "George Orwell", "Science", 1949, 11, 10000));
        }

        public void DisplayLibrary()
        {
            foreach (var item in bookList)
            {
                Console.WriteLine(item.DisplayBookInformation());
            }
        }
        public void DisplaySearchBook()
        {
            Console.WriteLine("Enter choice: ");
            Console.WriteLine("1. Search Book's Name ");
            Console.WriteLine("2. Search Book's Author");
            Console.WriteLine("3. Search Book's Category");
            Console.Write("Enter choice: ");
            int find = int.Parse(Console.ReadLine());
            if (find == 1)
            {
                Console.Write("Enter Book's Name: ");
                string temporaryName = Console.ReadLine();
                List<BookLibrary> listName = SearchBookName(temporaryName);
                if (listName.Count > 0)
                {
                    foreach (var item in listName)
                    {
                        Console.WriteLine(item.DisplayBookInformation());
                    }
                }
                else
                {
                    Console.WriteLine("ERROR !!! Please try again");
                }
            }
            else if (find == 2)
            {
                Console.Write("Enter Book's Author: ");
                string temporaryAuthor = Console.ReadLine();
                List<BookLibrary> listAuthor = SearchBookAuthor(temporaryAuthor);
                if (listAuthor.Count > 0)
                {
                    foreach (var item in listAuthor)
                    {
                        Console.WriteLine(item.DisplayBookInformation());
                    }
                }
                else
                {
                    Console.WriteLine("ERROR !!! Please try again");
                }
            }
            else if (find == 3)
            {
                Console.Write("Enter Book's Category: ");
                string temporaryCategory = Console.ReadLine();
                List<BookLibrary> listCategory = SearchBookCategory(temporaryCategory);
                if (listCategory.Count > 0)
                {
                    foreach (var item in listCategory)
                    {
                        Console.WriteLine(item.DisplayBookInformation());
                    }
                }
                else
                {
                    Console.WriteLine("ERROR !!! Please try again!");
                }
            }
            else
            {
                Console.WriteLine("ERROR !!! Please try again!");
            }
        }

        public List<BookLibrary> SearchBookName(string name)
        {
            List<BookLibrary> bookLibrary = new List<BookLibrary>();
            foreach (var item in bookList)
            {
                if (item.BookName.Contains(name))
                {
                    bookLibrary.Add(item);
                }
            }
            return bookLibrary;
        }
        public List<BookLibrary> SearchBookAuthor(string author)
        {
            List<BookLibrary> bookLibrary = new List<BookLibrary>();
            foreach (var item in bookList)
            {
                if (item.BookAuthor.Contains(author))
                {
                    bookLibrary.Add(item);
                }

            }
            return bookLibrary;
        }
        public List<BookLibrary> SearchBookCategory(string category)
        {
            List<BookLibrary> bookLibrary = new List<BookLibrary>();
            foreach (var item in bookList)
            {
                if (item.BookCategory.Contains(category))
                {
                    bookLibrary.Add(item);
                }

            }
            return bookLibrary;
        }
        public void AddBook()
        {
            Console.Write("Enter Updated Book's Quantity: ");
            int NumberOfBooks = int.Parse(Console.ReadLine());
            for (int i = 0; i < NumberOfBooks; i++)
            {
                BookLibrary bookSystem = new BookLibrary();
                Console.Write("Book's Name: ");
                bookSystem.BookName = Console.ReadLine(); 
                Console.Write("Book's Author: ");
                bookSystem.BookAuthor = Console.ReadLine();
                Console.Write("Book's Category: ");
                bookSystem.BookCategory = Console.ReadLine();
                Console.Write("Book's Publication Date: ");
                bookSystem.BookPublicationDate = int.Parse(Console.ReadLine());
                Console.Write("Book's Quantity: ");
                bookSystem.BookQuantity = int.Parse(Console.ReadLine());
                Console.Write("Book's Price: ");
                bookSystem.BookPrice = int.Parse(Console.ReadLine());
                Console.WriteLine("UPDATED!");
                bookList.Add(bookSystem);
            }
        }
        public void RemoveBook(string delete)
        {
            foreach (var item in bookList)
            {
                if (item.BookName == delete)
                {
                    Console.WriteLine("DELETED!");
                    bookList.Remove(item);
                    break;
                }
            }
        }
    }
}
