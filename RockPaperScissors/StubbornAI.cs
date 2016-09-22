using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {
        private int favoriteMove;

        public StubbornAI(int favoriteMove)
        {

        }

        public int NextMove()
        {
            return favoriteMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //nothing goes here
        }
    }
}
