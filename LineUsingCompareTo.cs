using System;
using System.Collections.Generic;
using System.Text;

namespace empWageDay3
{
    class LineUsingCompareTo
    {
        public static void lineUsingCompareTo()
        {

            float X1 = 4;
            float X2 = 5;
            float Y1 = 7;
            float Y2 = 3;
            float lengthOfL1 = (float)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine(lengthOfL1);

            float P1 = 1;
            float P2 = 2;
            float Q1 = 3;
            float Q2 = 4;

            float lengthOfL2 = (float)Math.Sqrt(Math.Pow(P2 - P1, 2) + Math.Pow(Q2 - Q1, 2));
            Console.WriteLine(lengthOfL2);

            double status = lengthOfL1.CompareTo(lengthOfL2);
            
            }
        }
    }
}
