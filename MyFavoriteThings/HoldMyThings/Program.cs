using System;
using MyFavoriteThings.HoldMyThings.Animals;
using MyFavoriteThings.HoldMyThings.VideoGames;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {

            var myFavDog = new MyDog();
            myFavDog.IMakeThisSound();

            var myFavIvan = new MyCat();
            myFavIvan.BestBoy();

            var myFavBird = new RedWing();
            myFavBird.RedWingCalls();

            var randomInsectWhoops = new LadyBug();
            randomInsectWhoops.WhatSoundDoIMake();

            var myFavMonster = new MonsterHunterWorld();
            myFavMonster.PukeiPukei();

            var myFavYakuza = new Yakuza();
            myFavYakuza.Majima();

            var myFavCounterStrike = new CounterStrike();
            myFavCounterStrike.CT();

            var myFavLeftForDead = new LeftForDead();
            myFavLeftForDead.Ellis();

            var myFavOW = new Overwatch();
            myFavOW.JunkRat();

            //var myFavGame = new VideoGame("Overwatch", "JunkRat", "Reinhardt");

            //myFavGame.ItIsKnown();
            //myFavGame.MyCharacter();
            //myFavGame.WorstCharacter();

            //Console.ReadLine();

            //var myKindOfComputer = new MyComputer("HyperBeast", "Scream One", ComputerType.gaming);

            //myKindOfComputer.HyperBeast();
            //myKindOfComputer.TheMouse();
            //myKindOfComputer.WhatDoYouHave();

            //Console.ReadLine();

            //var myPlants = new Plants("Perennials", "Annuals", "WoodyLandscapes");

            //myPlants.AllPerennials();
            //myPlants.AllAnnuals();
            //myPlants.AllWoody();

            Console.ReadLine();
        }
    }
}