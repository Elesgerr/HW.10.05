using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBooks.Models
{
    class Book
    {
       
        Library library1 = new Library();
        public readonly string Code;
        private static int _count;
        private static int _age;
        public string Name { get; set; }
        public int PageCount { get; set; }
        public string AuthorName { get; set; }
        public List<Book> books { get; set; }
        
        static Book()
        {
            _count = 1;
        }
        public Book()
        {
            books = new List<Book>();
        }

        public Book(string name, string authorname, int pagecount, Library library)
        {
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            _count++;
            Code = $"{library.ToString()[0]}{_count}";        
        }
      
        public void Namee(string value)
        {
          
        }     
    }
   
}
