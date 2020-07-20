using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballGameCommandLineAndLogic
{
    class InningHalf
    {
        private int outs = 0;
        private int strikes = 0;
        private int balls = 0;
        private int score = 0;

        public InningHalf()
        {

        }

        public int RunInningHalf()
        {
            bool inningInProgress = true;
            while(inningInProgress)
            {
                if(outs == 3)
                {
                    inningInProgress = false;
                }
                else
                {
                    AtBat();
                }
            }
            return score;
        }

        private void AtBat()
        {
            bool stillBatting = true;
            while (stillBatting)
            {
                Console.WriteLine("1) Ball 2) Strike 3) Foul 4) Hit: ");
                int result = Int32.Parse(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        balls++;
                        break;
                    case 2:
                        strikes++;
                        break;
                    case 3:
                        if (strikes == 2) ; // Do Nothing
                        else strikes++;
                        break;
                    case 4:
                        Hit();
                        balls = 0;
                        strikes = 0;
                        break;
                }
                if(strikes == 3)
                {
                    outs++;
                    strikes = 0;
                    balls = 0;
                    stillBatting = false;
                }
                Console.WriteLine($"Strikes: {strikes} Balls: {balls} Outs: {outs}");
            }
        }

        private void Hit()
        {
            throw new NotImplementedException();
        }
    }
}
