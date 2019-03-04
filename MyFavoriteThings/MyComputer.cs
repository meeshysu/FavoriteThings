using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class MyComputer
    {
        public string ComputerCase { get; }
        public string Mouse { get; }
        public ComputerType Type { get; }

        public MyComputer(string computercase, string mouse, ComputerType type)
        {
            ComputerCase = computercase;
            Mouse = mouse;
            Type = type;
        }

        public void HyperBeast()
        {
            Console.WriteLine("My computer case is the HyperBeast edition, number 999, by NZXT. It's based off the Counter Strike skin.");
        }

        public void TheMouse()
        {
            Console.WriteLine("My gaming mouse is one of the best and lightest. It's called the 'Scream One'. Professional gamers use this mouse in comps.");
        }

        public void WhatDoYouHave()
        {
            Console.WriteLine("What kind of computer do you have?");
            Console.ReadLine();
            if (Type == ComputerType.gaming)
            {
                Console.WriteLine("You are accepted to the cool group.");
            }
            if (Type != ComputerType.gaming)
            {
                Console.WriteLine("Whatevs man.");
            }
        }
    }
    enum ComputerType
    {
        gaming
    }
}
