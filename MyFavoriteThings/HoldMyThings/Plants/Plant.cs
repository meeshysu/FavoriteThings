using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Plants
{
    abstract class Plant
    {
        public string PlantName { get; protected set; }
        public PlantType PlantType { get; protected set; }
        public bool HasFlowers { get; protected set; }
        public Colors Color { get; protected set; }

        public Plant(string plantName, PlantType plantType, bool hasFlowers, Colors color)
        {
            PlantName = plantName;
            PlantType = plantType;
            HasFlowers = hasFlowers;
            Color = color;
        }
    }

    enum PlantType
    {
        annual,
        perennial,
        tree,
        bush,
        succulent
    }

    enum Colors
    {
        pink,
        red,
        orange,
        blue,
        green,
        yellow
    }
}
