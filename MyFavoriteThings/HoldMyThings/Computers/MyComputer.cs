using System;
using System.Collections.Generic;
using System.Text;
namespace MyFavoriteThings
{
    class MyComputer
    {
        public int HowManyOf { get; protected set; }
        public bool HasBacklight { get; protected set; }
        public ComputerType Type { get; protected set; }

        public MyComputer(ComputerType type, int howManyOf, bool hasBacklight)
        {
            HowManyOf = howManyOf;
            HasBacklight = hasBacklight;
            Type = type;
        }
    }

    enum ComputerType
    {
        gaming,
        laptop,
        mac
    }
}