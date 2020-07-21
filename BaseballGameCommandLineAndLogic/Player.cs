using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballGameCommandLineAndLogic
{
    public enum TypeOfPlayer
    {
        FirstBaseman,
        SecondBaseman,
        ThirdBaseman,
        ShortStop,
        LeftFielder,
        CenterFielder,
        RightFielder,
        Pitcher,
        Catcher
    }

    class Player
    {
        private int atBats = 0;
        private string playerName;

        public Player(string name, TypeOfPlayer typeOfPlayer)
        {
            playerName = name;
        }

        public void Bat()
        {
            atBats++;
        }

        public virtual bool Steal()
        {
            return true;
        }
    }

    public enum TypeOfPitcher
    {
        Starter,
        Relief,
        Closer
    }

    class Pitcher : Player
    {
        private int pitches = 0;
        private TypeOfPitcher pitcherType;
        public Pitcher(string name, TypeOfPlayer typeOfPlayer, TypeOfPitcher typeOfPitcher) : base (name, typeOfPlayer)
        {
            pitcherType = typeOfPitcher;
        }

        public int Pitches
        {
            get;
        }
        
        public void Pitch()
        {
            pitches++;
        }
    }
}
