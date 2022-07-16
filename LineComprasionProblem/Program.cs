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

            Console.WriteLine( "Enter the Y1-cordinate:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the x2-cordinate:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Y2-cordinate:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double lengthOfLine = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));

            Console.WriteLine("Lenth of the line : " + lengthOfLine + "cm");
              





        }
    }
}
