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
            bool hitByPitch = false;
            while (stillBatting)
            {
                Console.WriteLine("1) Ball 2) Strike 3) Foul 4) Hit 5) Runner hit by pitch: ");
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
                    case 5:
                        balls = 4;
                        hitByPitch = true;
                        break;
                }
                if(strikes == 3)
                {
                    outs++;
                    strikes = 0;
                    balls = 0;
                    stillBatting = false;
                }
                if(balls == 4)
                {
                    AdvanceBases(hitByPitch);
                    balls = 0;
                    strikes = 0;
                }
                Console.WriteLine($"Strikes: {strikes} Balls: {balls} Outs: {outs}");
            }
        }

        private void AdvanceBases(bool hitByPitch)
        {
            if(hitByPitch)
            {
                Console.WriteLine("Runner is hit by pitch and advances to first.")
            }
            else
                Console.WriteLine("Runner advances to first.");
        }

        private void Hit()
        {
            Console.WriteLine("Runner got a hit.");
        }
    }
}
