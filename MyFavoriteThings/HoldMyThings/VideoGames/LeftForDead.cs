using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.VideoGames
{
    class LeftForDead : VideoGame 
    {
        public LeftForDead() : base("Left For Dead 2", VideoGameType.Zombies, true, 2)
        {
        }

        public void Ellis()
        {
            Console.WriteLine("I ever tell you about the time my buddy Keith drowned in the Tunnel of Love? You wouldn't think it could happen 'cause the water's so shallow, but that's how it gets you, man. Overconfidence. Keith was with his lady at the time, and he was yellin' for her to save him, but she didn't want to get wet.");
        }

        public void Coach()
        {
            Console.WriteLine("God dammit, I knew I shoulda lost some weight.");
        }

        public void Zoey()
        {
            Console.WriteLine("Free copy paper?! Sweet! The apocalypse was totally worth it!");
        }

        public void Francis()
        {
            Console.WriteLine("I hate elevators. I hate helicopters. I hate hospitals. And doctors and lawyers and cops...");
        }
    }
}
