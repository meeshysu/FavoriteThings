using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class VideoGame
    {
        public string Overwatch { get; }
        public string JunkRat { get; }
        public string Reinhardt { get; }

        public VideoGame(string overwatch, string junkrat, string reinhardt)
        {
            Overwatch = overwatch;
            JunkRat = junkrat;
            Reinhardt = reinhardt;
        }

        public void ItIsKnown()
        {
            Console.WriteLine("My favorite game is Overwatch and I am damn good at it.");
        }

        public void MyCharacter()
        {
            Console.WriteLine("My favorite character to play is Junkrat, but I love playing Ashe too");
        }

        public void WorstCharacter()
        {
            Console.WriteLine("One of the worst characters to play is Reindhart. Lame.");
        }
    }
}
