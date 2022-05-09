using System;
using System.Collections.Generic;
using System.Text;
using LibraryBooks2.Interfaces;
using LibraryBooks2.Models;
using System.IO;

namespace LibraryBooks2.Services
{
    class LibraryManager : ILibraryManager
    {
        
        Book book = new Book();
        LibraryManager libraryManager = new LibraryManager();
        int ae = -1;
        string input;
        bool ise = true;


        List<Book> books = new List<Book>
        {

             new Book { Name = "Simyacı",Genre = "Roman",AuthorName = "Paulo Coelho", PageCount = 255 },
             new Book { Name = "Tutunamayanlar",Genre = "Roman" , AuthorName = "Oğuz Atay", PageCount = 312 },
             new Book { Name = "Nietzsche Ağladığında",Genre = "Düşünce romanı",AuthorName = "Irvin D. Yalom", PageCount = 287 },
             new Book { Name = "Romeo ve Juliet ",Genre = "	Shakespearean tragedy", AuthorName = "William Shakespeare", PageCount = 323 },
        };

        public void Add(Book b1)
        {
            List<Book> books = new List<Book>();          
            input = Console.ReadLine();
            books.Add(b1);
        }

        public void ShowInfo()
        {
            Console.WriteLine(books);
            book.Name = Console.ReadLine();
            if (File.Exists(book.Name))
            {
                Console.WriteLine("BookNotFoundException ");
            }           
        }

        public void Search()
        {
            Console.WriteLine(books);
            
            string ase = Console.ReadLine();
            ase = book.Name;
            Console.WriteLine(ase);



            //while ((!(ise = Int32.TryParse(input, out ae))) ||
            //ae < 1 ||
            //ae > 3) ;
            //return ae;

        }

        public void Filter()
        {
            //string a;
            //a = Console.ReadLine();
            Console.WriteLine(books);
            string asee = Console.ReadLine();
            asee = book.AuthorName;
            asee = book.Genre;
            Console.WriteLine(asee);
            

        }
       
    }
}
