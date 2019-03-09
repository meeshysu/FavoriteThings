using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Computers
{
    class ComputerCase : MyComputer
    {
        public ComputerCase() : base(ComputerType.gaming, 1, true)
        {
        }

        public void MyCase()
        {
            Console.WriteLine("My computer case is the HyperBeast edition, number 999, by NZXT. It's based off the Counter Strike skin.");
        }

        public void Whisper()
        {
            Console.WriteLine("Turn me on and her me gently run with powerful speeds, like the beast I am.");
        }
    }
}
