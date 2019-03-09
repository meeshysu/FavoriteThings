using System;
using MyFavoriteThings.HoldMyThings.Animals;
using MyFavoriteThings.HoldMyThings.Computers;
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

            var myFavComputerMouse = new Mouse();
            myFavComputerMouse.Click();

            var myFavKeyboard = new Keyboard();
            myFavKeyboard.ClickClack();

            var myFavCase = new ComputerCase();
            myFavCase.Whisper();

            var myFavLaptop = new Laptop();
            myFavLaptop.ClickClackGlow();

            Console.WriteLine("What kind of computer do you have?");
            var computerChoice = Console.ReadLine().ToLower();
            if (computerChoice == "gaming")
            {
                Console.WriteLine("You're super cool.");
            } else if (computerChoice == "mac"){
                Console.WriteLine("Uh yeah you're a loser...");
            } else if (computerChoice == "laptop")
            {
                Console.WriteLine("If it's a mac, well you know you suck, but if it's a PC then we good.");
            }
            

            Console.ReadLine();
        }
    }
}