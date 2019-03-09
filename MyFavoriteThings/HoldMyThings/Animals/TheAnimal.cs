using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Animals
{
    abstract class TheAnimal
    {
        public AnimalType AnimalType { get; protected set; }
        public bool HasFur { get; protected set; }
        public bool HasWings { get; protected set; }
        public int LegCount { get; protected set; }


        protected TheAnimal(AnimalType animalType, bool hasFur, bool hasWings, int legCount)
        {
            AnimalType = animalType;
            HasFur = hasFur;
            HasWings = hasWings;
            LegCount = legCount;
        }

        public virtual void IMakeThisSound()
        {
            Console.WriteLine("Burps");
        }
    }

    internal enum AnimalType
    {
        Cat,
        Dog,
        Insect,
        Bird,
        Unknown
    }
}
