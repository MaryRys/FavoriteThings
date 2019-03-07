using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.FavoriteThings
{
    class Friends
    {
        //properties
        public Name Name { get; set; }
        public bool IsBestFriend { get; set; }

        //methods
        public string Walk()
        {
            return ("I'm walking away now...");
        }

        public void Wave()
        {
            Console.WriteLine("waves at you");
        }
    }
}
