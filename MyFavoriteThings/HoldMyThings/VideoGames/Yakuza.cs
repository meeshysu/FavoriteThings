using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.VideoGames
{
    class Yakuza : VideoGame
    {
        public Yakuza() : base("Yakuza O", VideoGameType.ActionRPG, true, 6)
        {
        }

        public void Kiryu()
        {
            Console.WriteLine("Beast Mode!!");
        }

        public void Majima()
        {
            Console.WriteLine("Pummel Mode!!");
        }
    }
}
