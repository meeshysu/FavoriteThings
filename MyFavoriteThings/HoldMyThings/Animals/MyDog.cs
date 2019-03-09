using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Animals
{
    class MyDog : TheAnimal
    {
        public MyDog() : base(AnimalType.Dog, true, false, 4)
        {
        }

        public override void IMakeThisSound()
        {
            Console.WriteLine("Ruff! Ruff!");
        }

        public void Bark()
        {
            Console.WriteLine("I love to bark when we play!");
        }
    }
}
