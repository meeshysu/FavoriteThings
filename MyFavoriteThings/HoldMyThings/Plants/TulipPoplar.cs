using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.Plants
{
    class TulipPoplar : Plant
    {
        public TulipPoplar() : base("Tulip Poplar", PlantType.tree, true, Colors.yellow)
        {
        }

        public void TreeTalk()
        {
            Console.WriteLine("I am the TN state tree, did you know that? And one of the tallest hardwood trees, too.");
        }
    }
}
