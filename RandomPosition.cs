using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class RandomPosition
    {
        public static void PlayerPosition()
        {
            
            Random random = new Random();
            int RollDice = random.Next(1, 6);
            Console.WriteLine("Player rolls the dice and get: " + RollDice);
        }
    }
}
