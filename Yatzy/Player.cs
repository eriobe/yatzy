using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    public abstract class Player
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public virtual int Bonus {
            get
            {
                if (ResultUpper.Sum() >= 62)
                    return 50;
                else
                    return 0;
            }
        }
        public int[] ResultUpper { get; set; }

        public int GetScore()
        {
            // [2] [6] [12] 
            int sum = 0;
            foreach (int value in ResultUpper)
            {
                sum += value;
            }
            return sum;
        }

        public virtual int GetBonus()
        {
            if (GetScore() >= 62)
            {
                return 50;
            }
            else
            {
                return 0;
            }
        }

        public Player()
        {
            ResultUpper = new int[6];
        }
    }
    
}
