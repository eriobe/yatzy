using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    class Child : Player
    {
        public override int Bonus
        {
            get
            {
                if (ResultUpper.Sum() >= 50)
                    return 50;
                else
                    return 0;
            }
        }
        public override int GetBonus()
        {
            if (GetScore() >= 50)
            {
                return 50;
            }
            else
            {
                return 0;
            }
        }
    }
}
