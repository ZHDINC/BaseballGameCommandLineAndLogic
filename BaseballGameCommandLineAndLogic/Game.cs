using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballGameCommandLineAndLogic
{
    class Game
    {
        private Team awayTeam;
        private Team homeTeam;
        private List<int> inningListing = new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private int currentInning = 1;
        private Inning inningType = Inning.TopOfInning;
        private bool gameInProgress = true;
        public Game(Team away, Team home)
        {
            awayTeam = away;
            homeTeam = home;
        }

        public Team AwayTeam
        {
            get => awayTeam;
        }

        public Team HomeTeam
        {
            get => homeTeam;
        }

        public void RunGame()
        {
            while (gameInProgress)
            {
                InningHalf inning = new InningHalf();
                inning.RunInningHalf();
                if(inningType == Inning.TopOfInning && currentInning < 9)
                {
                    inningType = Inning.BottomOfInning;
                }
                else if(inningType == Inning.BottomOfInning && currentInning < 9)
                {
                    currentInning++;
                }
                else if(inningType == Inning.TopOfInning && currentInning >= 9)
                {
                    if(homeTeam.Score > awayTeam.Score)
                    {

                    }
                    inningType = Inning.BottomOfInning;
                }
                else if(inningType == Inning.BottomOfInning && currentInning >= 0)
                {
                    if(homeTeam.Score > awayTeam.Score)
                    {

                    }
                    else if(homeTeam.Score < awayTeam.Score)
                    {

                    }
                    else
                    {
                        currentInning++;
                        inningListing.Add(currentInning);
                        inningType = Inning.TopOfInning;
                    }
                }
            }
        }
    }
}
