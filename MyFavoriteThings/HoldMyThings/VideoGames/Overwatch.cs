using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.VideoGames
{
    class Overwatch : VideoGame
    {
        public Overwatch() : base("Overwatch", VideoGameType.PVP, true, 1)
        {
        }

        public void JunkRat()
        {
            Console.WriteLine("Everything is coming up explodey!");
        }

        public void Ashe()
        {
            Console.WriteLine("Just takin' out the trash...");
        }
        
        public void Lucio()
        {
            Console.WriteLine("Oh yeah! Feel the beat!");
        }

        public void Orisa()
        {
            Console.WriteLine("I'm sill a little new at this...");
        }
    }
}
