using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.HoldMyThings.VideoGames
{
    class MonsterHunterWorld : VideoGame
    {
        public MonsterHunterWorld() : base("Monster Hunter World", VideoGameType.ActionRPG, false, 11)
        {
        }

        public void Nergigante()
        {
            Console.WriteLine("Immediate threat at medium distance... RUNNNNN NOWWW!!! DIVE DIVE!!");
        }

        public void TobiKadachi()
        {
            Console.WriteLine("Hope you are resistance to thunder--! -iselectrocuted- ZZZZZZZ!! OW!");
        }

        public void PukeiPukei()
        {
            Console.WriteLine("-gags- -purple poison stuff comes out- Ew.");
        }
    }

}
