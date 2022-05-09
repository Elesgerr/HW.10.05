using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBooks.Models
{
    class Library
    {
        public Library()
        {
            List<string> name = new List<string>();                             
        }
        public void FindAllBooksByName()
        {
            List<string> names = new List<string>();
            names.Add("");
            Console.WriteLine(names);
        }
        public void RemoveAllBookByName()
        {
            //List<string> Value = new List<string>();
            //Value.Remove("Küçük Prens");
            //Value.Remove("Yüzyıllık Yalnızlık ");
        }
      
        public void SearchBooks(Book book)
        {
           
        }
        public void FindAllBooksByPageCountRange(int a, int b, Book book)
        {

        }

    }
}
