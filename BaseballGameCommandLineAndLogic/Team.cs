using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballGameCommandLineAndLogic
{
    class Team
    {
        private List<Player> playersInGame;
        private List<Player> playerList;
        private int score = 0;
        public Team(List<Player> players)
        {
            playerList = players;
        }

        public int Score
        {
            get; set;
        }
    }
}
