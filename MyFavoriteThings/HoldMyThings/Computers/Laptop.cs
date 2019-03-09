using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Computers
{
    class Laptop : MyComputer
    {
        public Laptop() : base(ComputerType.laptop, 1, false)
        {
        }

        public void MyLaptop()
        {
            Console.WriteLine("I don't really do anything besides school work, heehee!");
        }

        public void ClickClackGlow()
        {
            Console.WriteLine("My keyboard quietly clacks, my Kova mouse glows and clicks. I'm a cool Asus.");
        }
    }
}
