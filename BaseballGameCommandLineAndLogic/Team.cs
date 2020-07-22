using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballGameCommandLineAndLogic
{
    class Team
    {
        private Player[] playersInGame = new Player[9];
        private List<Player> playerList;
        private int score = 0;
        private int playerIterator = 0;
        private string teamName;
        public Team(List<Player> players, string name)
        {
            teamName = name;
            playerList = players;
        }

        public int Score
        {
            get; set;
        }
        public string Name
        {
            get => teamName;
        }

        public Player NextBatter()
        {
            return playersInGame[playerIterator++];
        }

        public bool LoadPlayers()
        {
            // TODO: Load players/batting order from playerList into playersInGame

            return ValidatePlayers();
        }

        public bool ValidatePlayers()
        {
            return true;
        }
    }
}
