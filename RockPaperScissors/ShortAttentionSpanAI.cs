using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI : IPlayer
    {


        private int plannedMove = 1;

        public int NextMove()
        {
            return plannedMove;
        }
        public void SaveResult(int myMove, int otherMove)
        {
            if (otherMove == 0)
            {
                plannedMove = 1;
            }
            if (otherMove == 1)
            {
                plannedMove = 2;
            }
            if (otherMove == 2)
            {
                plannedMove = 0;
            }
            
        }
    }
}
