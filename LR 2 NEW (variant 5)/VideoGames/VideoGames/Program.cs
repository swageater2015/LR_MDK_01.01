using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>();
            games.Add(new Game() { Name = "Dota 2", Genre = "strategy", Downloads = 1000 });
            games.Add(new Game() { Name = "Phasmophobia", Genre = "horror", Downloads = 500 });
            games.Add(new Game() { Name = "World of Warcraft", Genre = "strategy", Downloads = 800 });
            games.Add(new Game() { Name = "Counter-Strike 2", Genre = "shooter", Downloads = 1000 });
            games.Add(new Game() { Name = "Apex Legends", Genre = "shooter", Downloads = 700 });
            Console.WriteLine("Введите жанр игры:");
            string genre = Console.ReadLine();
            foreach (Game g in games)
            {
                if (Genre = genre)
            }
        }
    }
}
g