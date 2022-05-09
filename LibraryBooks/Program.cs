using System;
using System.Collections.Generic;
using System.Linq;
using LibraryBooks.Models;

namespace LibraryBooks
{
    class Program
    {
        private static IEnumerable<object> book;
        private static int _pagecount;

        static void Main(string[] args)
        {

            var names = new List<Book>()
            {
                new Book(){ Name = "Suç ve Ceza: ", AuthorName = "Fyodor Dostoyevski", PageCount = 232 },
                new Book(){ Name = "Dönüşüm: ", AuthorName = "Franz Kafka", PageCount = 254 },
                new Book(){ Name = "İlahi Komedya: ", AuthorName = "Dante", PageCount = 273  },
                new Book(){ Name = "Yüzyıllık Yalnızlık: ", AuthorName = "Gabriel García Márquez", PageCount = 291 },
                new Book(){ Name = "Küçük Prens: ", AuthorName = "Gabriel García Márquez", PageCount = 295 },

            };
            Library library = new Library();
            Book book = new Book();
            //Book book1 = new Book { Name = "Suç ve Ceza: ", AuthorName = "Fyodor Dostoyevski", PageCount = 232 };
            //Book book2 = new Book { Name = "Dönüşüm: ", AuthorName = "Franz Kafka", PageCount = 254 };
            //Book book3 = new Book { Name = "İlahi Komedya: ", AuthorName = "Dante", PageCount = 273 };
            //Book book4 = new Book { Name = "Yüzyıllık Yalnızlık: ", AuthorName = "Gabriel García Márquez", PageCount = 291 };
            //Book book5 = new Book { Name = "Küçük Prens: ", AuthorName = "Gabriel García Márquez", PageCount = 295 };
            //List<Book> theBooks = new List<Book>();

            //theBooks.Add(book1);
            //theBooks.Add(book2);
            //theBooks.Add(book3);
            //theBooks.Add(book4);
            //theBooks.Add(book5);
            //Console.WriteLine(theBooks); 
         
            static void FindAllBooksByName(List<Book> names)
            {
                foreach (var book in names)
                {
                    Console.WriteLine("Kitabin adi : {0}");
                }

            }
            static void RemoveAllBookByName(string value, Book book, List<Book> theBooks, List<Book> names)
            {
                names.RemoveAt(0);
                
                //Test
                //theBooks.RemoveAt(4);
                //foreach (string item in Program.book)
                //{
                //    Console.WriteLine(book.Name, book.AuthorName);
                //}
                //foreach (string s in value)
                //{
                //    if (s == "b")
                //        value.Remove(s);
                //}
            }
            static void SearchBooks( List<Book> names)
            {
                foreach (var book in names)
                {
                    Console.WriteLine("Kitabin adi : {0} Yazarin Adi : {1}");
                }

                //Test
                //foreach (var item in Program.book)
                //{
                //    Console.WriteLine(book.Name, book.AuthorName, book.PageCount);
                //}


            }        
            static int FindAllBooksByPageCountRange(int value, Book book, List<Book> names)
            {
                if (book.PageCount > 250 && book.PageCount < 300)
                {
                    _pagecount = book.PageCount;
                }
                else
                {
                    Console.WriteLine("duzgun daxil et");
                }
                
                return _pagecount;
                //book.PageCount = a;
                //if (a > 250)
                //{

                //}
                //else if (a < 300)
                //{

                //}
                //else
                //{
                //    Console.WriteLine("Eded Yoxdur");
                //}
            }
            static void RemoveByNo(int a,Book book, List<Book> theBooks, List<Book> names)
            {
                names.RemoveAt(book.PageCount);

                //test
                //book.PageCount = a;
                //theBooks.RemoveAt(a);
            }                       

        }
    }
    internal class List<T1, T2>
    {
        public List()
        {
        }
    }
}
