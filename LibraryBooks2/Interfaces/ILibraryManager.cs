using LibraryBooks2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBooks2.Interfaces
{
    interface ILibraryManager
    {
       
        void Add(Book b1);
        void ShowInfo();
        void Search();
        void Filter();


    }
}
