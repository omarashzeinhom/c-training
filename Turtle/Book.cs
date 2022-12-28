using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle
{
    internal class Book
    {
        //class attributes what a book is
        public string title;
        public string author;
        public int pages;
        // Using constructors Book to be dynamic check Program.cs 
        // CHECK Program.cs Line 476 
        public Book(string aTitle,
            string anAuthor,
            int allPages)
        {
         
            title = aTitle;
            author = anAuthor;
            pages = allPages;
       

        }

    }
}
