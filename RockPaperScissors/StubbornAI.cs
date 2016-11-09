using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {
        Random start;
        private int favoriteMove;

        public StubbornAI()
        {
            start = new Random();
            favoriteMove = start.Next(3);
        }

        public int NextMove()
        {
            return favoriteMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            favoriteMove = myMove;
        }
    }
}
