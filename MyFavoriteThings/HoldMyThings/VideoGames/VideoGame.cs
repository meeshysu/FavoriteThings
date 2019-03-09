using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    abstract class VideoGame
    {
        public string GameName { get; protected set; }
        public VideoGameType VideoGameType { get; protected set; }
        public bool IsPC { get; protected set; }
        public int HowManyInSeries { get; protected set; }

        protected VideoGame(string gamename, VideoGameType videogameType, bool isPC, int howManyInSeries)
        {
            VideoGameType = videogameType;
            GameName = gamename;
            IsPC = isPC;
            HowManyInSeries = howManyInSeries;
        }
    }

    internal enum VideoGameType
    {
        PVP,
        MMO,
        Zombies,
        FPS,
        HackNSlash,
        ActionRPG
    }
}