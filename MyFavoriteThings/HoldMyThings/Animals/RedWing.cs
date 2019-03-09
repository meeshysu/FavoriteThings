using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Animals
{
    class RedWing : TheAnimal
    {
        public RedWing() : base(AnimalType.Bird, false, false, 2)
        {
        }

        public void RedWingCalls()
        {
            Console.WriteLine("This... cannot be immitated by text.. 'CAAAAHHH'??");
        }

        public void FlappingWings()
        {
            Console.WriteLine("Flap flap!");
        }
    }
}
