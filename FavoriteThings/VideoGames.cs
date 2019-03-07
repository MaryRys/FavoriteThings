using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.FavoriteThings
{
    class VideoGames
    {
        public bool NeedsUpdate { get; set; }
        public int NumberOfLevels { get; set; }

        public void BootUp()
        {
            Console.WriteLine("Loading...");
        }

        public string Play()
        {
            return "Start playing your game now!";
        }
    }
}
