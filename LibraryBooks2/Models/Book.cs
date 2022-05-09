using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBooks2.Models
{
    class Book
    {
        public readonly string Code;
        private static int _count;
        private static int _age;
        public string Name { get; set; }
        public string Genre { get; set; }     
        public int PageCount { get; set; }
        public string AuthorName { get; set; }
        public Book(string name, string genre, int pagecount, string authorname)
        {
            Name = name;
            Genre = genre;
            PageCount = pagecount;
            AuthorName = authorname;

        }

        public Book()
        {
        }
    }
}
