using System;
using System.Collections.Generic;

namespace BaseballGameCommandLineAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> homeTeamPlayers = new List<Player>()
            {
                new Player("Yorlf Burgan", TypeOfPlayer.FirstBaseman)
            };
            List<Player> awayTeamPlayers = new List<Player>()
            {
                new Player("Velaz DeSanto", TypeOfPlayer.FirstBaseman)
            };
            Team homeTeam = new Team(homeTeamPlayers, "Team 1");
            Team awayTeam = new Team(awayTeamPlayers, "Team 2");
            Game game = new Game(homeTeam, awayTeam);
            game.RunGame();
        }
    }
}
