using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.FavoriteThings
{
    class Pets
    {
        //properties
        public Species Species { get; set; }
        public bool LovesMe { get; set; }

        //methods
        public string Talk()
        {
            return ("Animal Noises!!");
        }

        public void Sleep()
        {
            Console.WriteLine("Zzzzz...");
        }
    }
}

enum Species
{
    Dog,
    Cat,
    Hamster,
    Lion
}
