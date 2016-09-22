using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomAI : IPlayer
    {

        Random randy;

        public RandomAI()
        {
            randy = new Random();
        }

        public int NextMove()
        {
            
            return randy.Next(3);
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //does nothing
        }

        
    }
}
