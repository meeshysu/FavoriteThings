using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Computers
{
    class Mouse : MyComputer
    {
        public Mouse() : base(ComputerType.gaming, 3, false)
        {
        }

        public void TheMouse()
        {
            Console.WriteLine("My gaming mouse is one of the best and lightest. It's called the 'Zowie F2K'. Professional gamers use this mouse in comps.");
        }

        public void Click()
        {
            Console.WriteLine("Click me! I am a Zowie!");
        }
    }
}
