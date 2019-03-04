using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Plants
    {
        public string Perennials { get; }
        public string Annuals { get; }
        public string WoodyLandscapes { get; }

        public Plants(string perennials, string annuals, string woodylandscapes)
        {
            Perennials = perennials;
            Annuals = annuals;
            WoodyLandscapes = woodylandscapes;
        }

        public void AllPerennials()
        {
            Console.WriteLine("Perennials are plants that flower and come back each year. They help attract all sorts of insects.");
        }

        public void AllAnnuals()
        {
            Console.WriteLine("Annuals unfortunately die every year and must be replanted; however, they attract many a beneficial insect and make your front porch look da bomb.");
        }

        public void AllWoody()
        {
            Console.WriteLine("Woody landscape plants consist of shrubs and trees. Many trees and shrubs bloom - for instance the Almond bush or the Apple tree. Gorgeous.");
        }
    }
}
