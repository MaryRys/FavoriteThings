using FavoriteThings.FavoriteThings;
using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodBook = new Books();
            var badBook = new Books();

            var bestPet = new Pets();
            var worstPet = new Pets();

            var badFriend = new Friends();
            var favoriteFriend = new Friends();

            var bestGame = new VideoGames();
            var worstGame = new VideoGames();


            goodBook.Shelf();
            badBook.Open();

            Console.ReadLine();
        }
    }
}
