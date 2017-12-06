using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlerGame
{
    public class Game
    {
       
        int bonus = 0;
        public void Roll(int pinsKnockedDown)
        {
            var numberOfPins = 10;
            numberOfPins -= pinsKnockedDown;
        }

        public int Score()
        {
            return 0;
        }
    }
}
