using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Computers
{
    class Keyboard : MyComputer
    {
        public Keyboard() : base(ComputerType.gaming, 2, true)
        {
        }

        public void TheKeyboard()
        {
            Console.WriteLine("Ducky One Skyline and Ducky One Shine");
        }

        public void ClickClack()
        {
            Console.WriteLine("Click clack click clack! I am a Ducky!");
        }
    }
}
