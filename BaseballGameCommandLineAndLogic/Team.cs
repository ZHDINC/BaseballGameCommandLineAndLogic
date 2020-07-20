using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballGameCommandLineAndLogic
{
    class Team
    {
        private List<Player> playersInGame;
        private List<Player> playerList;
        public Team(List<Player> players)
        {
            playerList = players;
        }
    }
}
