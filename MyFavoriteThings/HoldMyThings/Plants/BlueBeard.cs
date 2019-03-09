using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Plants
{
    class BlueBeard : Plant
    {
        public BlueBeard() : base("Blue Beard", PlantType.bush, true, Colors.blue)
        {
        }

        public void RunningOutOfThingsToNameAs()
        {
            Console.WriteLine("I am such a pretty blooming bush. Buy one.");
        }
    }
}
