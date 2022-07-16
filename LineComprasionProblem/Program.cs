using System;

namespace LineComprasionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line Computation Program :");
            Console.WriteLine("Enter the X1 cooridinate");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Y1-cordinate:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the x2-cordinate:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Y2-cordinate:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double lengthOfLine1 = Math.Sqrt(Math.Pow((x1 - 0), 2) + Math.Pow((y1 - 0), 2));

            double lengthOfLine2 = Math.Sqrt(Math.Pow((x2 - 0), 2) + Math.Pow((y2 - 0), 2));

            int relativeValueOfInstance = lengthOfLine1.CompareTo(lengthOfLine2);
            
            if(relativeValueOfInstance == -1)
            {
                Console.WriteLine("Line1 is smaller then Line2 ");
            }else if(relativeValueOfInstance == 1)
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
