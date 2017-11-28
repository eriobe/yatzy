using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Föreläsning2
{
   static class Calclulations
    {
      static public double Calculate(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Calculates value..
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="mathType"></param>
        /// <returns></returns>
       static public double Calculate(double a, double b, string mathType)
        {
            // sum difference product quotient
            double result =0;
            switch (mathType)
            {
                case "Sum":
                    result = a + b;
                    break;
                case "Difference":
                    result = a - b;
                    break;
                default:
                    result = -1;
                    break;
            }
            return result;
        }

        static public double Calculate(double a, double b, MathType mathType)
        {
            // sum difference product quotient
            double result = 0;
            switch (mathType)
            {
                case MathType.sum:
                    result = a + b;
                    break;
                case MathType.difference:
                    break;
                case MathType.product:
                    break;
                case MathType.quotient:
                    break;
                default:
                    break;
            }

            return result;
        }

    }
}
