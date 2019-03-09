using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Plants
{
    class PapayaConeflower : Plant
    {
        public PapayaConeflower() : base("Papaya Coneflower", PlantType.perennial, true, Colors.pink)
        {
        }

        public void TheFlower()
        {
            Console.WriteLine("I attract bees, buzzzzzz.");
        }

    }
}
