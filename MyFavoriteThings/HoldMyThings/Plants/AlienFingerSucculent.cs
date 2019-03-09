using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Plants
{
    class AlienFingerSucculent : Plant
    {
        public AlienFingerSucculent() : base("Alien Finger Succulent", PlantType.succulent, false, Colors.green)
        {
        }

        public void UFO()
        {
            Console.WriteLine("The real name of this plant is unknown to me and the plant looks like a bunch of alien fingers.");
        }
    }
}
