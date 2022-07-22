using System;
using System.Collections.Generic;
using System.Text;

namespace LineComprasionProblem
{
    class Gemotery
    {
        public static void LineComprasion(int x1,int y1,int x2,int y2)
        {
            double lengthOfLine1 = Math.Sqrt(Math.Pow((x1 - 0), 2) + Math.Pow((y1 - 0), 2));

            double lengthOfLine2 = Math.Sqrt(Math.Pow((x2 - 0), 2) + Math.Pow((y2 - 0), 2));

            int relativeValueOfInstance = lengthOfLine1.CompareTo(lengthOfLine2);

            if (relativeValueOfInstance == -1)
            {
                Console.WriteLine("Line1 is smaller then Line2 ");
            }
            else if (relativeValueOfInstance == 1)
            {
                Console.WriteLine("Line1 is greater then Line2 ");
            }
            else
            {
                Console.WriteLine("both lines are equal");
            }
        }
    }
}
