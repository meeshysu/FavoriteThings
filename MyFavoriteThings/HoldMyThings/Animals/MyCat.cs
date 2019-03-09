using System;
using System.Collections.Generic;
using System.Text;
using MyFavoriteThings.HoldMyThings.Animals;

namespace MyFavoriteThings
{
    class MyCat : TheAnimal
    {

        // Give these things two or more methods (behaviors)
        public MyCat() : base(AnimalType.Cat, true, false, 4)
        {
        }

        public void IvanSounds()
        {
            Console.WriteLine("Meowwwwwwww!! Mew!");
        }

        public void BestBoy()
        {
            Console.WriteLine("I have the best cat in the world and his name is Ivan.");
        }
    }
}