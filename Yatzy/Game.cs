using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
   public class Game
    {
        public Player PlayerOne { get; protected set; }
        public Player PlayerTwo { get; protected set; }

        public Game()
        {

        }
        // Konstruktor som tar två argument/parametrar
        public Game(Player playerOne, Player playerTwo)
        {
            this.PlayerOne = playerOne;
            this.PlayerTwo = playerTwo;
        }

        public int[] RollDices(bool[] savedDices)
        {
            Random random = new Random();
            int[] myDices = new int[5];

            // skapar en for-loop
            // startvärde  slutvärde   villkor för att öka
            for (int i = 0; i < myDices.Count(); i++)
            {
                if (!savedDices[i])
                {
                    myDices[i] = random.Next(1, 7);
                }
            }

            return myDices;

        }
    }
}
