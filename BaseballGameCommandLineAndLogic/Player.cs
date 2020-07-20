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

        
    }
}
