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


            //Console.WriteLine(lengthOfLine1.Equals(lengthOfLine2));
            if (lengthOfLine1.Equals(lengthOfLine2))
            {
                Console.WriteLine("Both lines are equal");
            }
            else
            {
                Console.WriteLine("Both lines are not equls");
            }





        }
    }
}
