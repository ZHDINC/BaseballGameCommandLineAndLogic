using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballGameCommandLineAndLogic
{
    class Game
    {
        private Team awayTeam;
        private Team homeTeam;
        public Game(Team away, Team home)
        {
            awayTeam = away;
            homeTeam = home;
        }

        public void AtBat(Player batter, Player pitcher)
        {
            
        }

        public Team AwayTeam
        {
            get => awayTeam;
        }

        public Team HomeTeam
        {
            get => homeTeam;
        }


    }
}
