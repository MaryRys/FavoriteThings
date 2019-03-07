using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.FavoriteThings
{
    class Books
    {
        //properties
        public Title Title { get; set; }
        public int PageCount { get; set; }
        public bool Fiction { get; set; }

        //methods
        public string Open()
        {
            return "I'm an open book.";
        }

        public void Shelf()
        {
            Console.WriteLine("I'm on the shelf");
        }
    }
}
