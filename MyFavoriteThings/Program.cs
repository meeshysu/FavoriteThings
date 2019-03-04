using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFavIvan = new MyCat("Ivan", "Fluffy", true);

            myFavIvan.BestBoy();
            myFavIvan.SuperSoft();
            myFavIvan.LetsTalk();

            Console.ReadLine();

            var myFavGame = new VideoGame("Overwatch", "JunkRat", "Reinhardt");

            myFavGame.ItIsKnown();
            myFavGame.MyCharacter();
            myFavGame.WorstCharacter();

            Console.ReadLine();

            var myKindOfComputer = new MyComputer("HyperBeast", "Scream One", ComputerType.gaming);

            myKindOfComputer.HyperBeast();
            myKindOfComputer.TheMouse();
            myKindOfComputer.WhatDoYouHave();

            Console.ReadLine();

            var myPlants = new Plants("Perennials", "Annuals", "WoodyLandscapes");

            myPlants.AllPerennials();
            myPlants.AllAnnuals();
            myPlants.AllWoody();

            Console.ReadLine();
        }
    }
}
