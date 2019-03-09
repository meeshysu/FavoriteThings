using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Animals
{
    class LadyBug : TheAnimal
    {
        public LadyBug() : base(AnimalType.Insect, false, false, 4)
        {
        }

        public void WhatSoundDoIMake()
        {
            Console.WriteLine("-ladybug sound goes here-");
        }
    }
}
