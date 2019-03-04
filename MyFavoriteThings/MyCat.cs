using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class MyCat
    {
        // Give these things two or more properties (attributes)
        public string Name { get; }
        public string Fluffy { get; }
        public bool Meow { get; }

        // Give these things two or more methods (behaviors)
        public MyCat(string name, string fluffy, bool meow)
        {
            Name = name;
            Fluffy = fluffy;
            Meow = meow;
        }

        public void BestBoy()
        {
            Console.WriteLine("I have the best cat in the world and his name is Ivan.");
        }

        public void SuperSoft()
        {
            Console.WriteLine("Ivan has the softest fur for a gray short haired cat.");
        }

        public void LetsTalk()
        {
            Console.WriteLine("He likes to talk all the time. We have the best conversations.");
        }
    }
}
