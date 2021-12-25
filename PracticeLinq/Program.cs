using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "street fighter, days gone, assasin creed, spiderman, GTA, Far Cry 6" };

            games.OrderBy(x => x.Length).ToList().ForEach(x => System.Console.WriteLine(x));

        }
    }
}
