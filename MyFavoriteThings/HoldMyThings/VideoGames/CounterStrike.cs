using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.VideoGames
{
    class CounterStrike : VideoGame
    {
        public CounterStrike() : base("CounterStrike Global Offensive", VideoGameType.FPS, true, 2)
        {
        }

        public void Terrorists()
        {
            Console.WriteLine("Easy peasy, lemon squeezy!");
        }

        public void CT()
        {
            Console.WriteLine("Are we rushing in? Or are we going sneaky-beaky like?");
        }
    }
}
