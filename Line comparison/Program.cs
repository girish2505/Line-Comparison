using System;

namespace Line_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation Problem");
            //initialising coordinates as integers
            int a1, a2, b1, b2, x1, x2, y1, y2;
            double lineOneLength, lineTwoLength;
            Console.WriteLine("Enter a-coordinate of First Point of First Line:");
            //converting into int using ToInt32
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b-coordinate of First Point First Line:");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a-coordinate of Second Point First Line:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b-coordinate of Second Point First Line:");
            b2 = Convert.ToInt32(Console.ReadLine());

            //getting inputs from user for Second line 
            Console.WriteLine("Enter a-coordinate of First Point of Second Line:");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b-coordinate of First Point Second Line:");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a-coordinate of Second Point Second Line:");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b-coordinate of Second Point Second Line:");
            y2 = Convert.ToInt32(Console.ReadLine());

            //formula for calculate length
            lineOneLength = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            lineTwoLength = Math.Sqrt(Math.Pow(x2 - a1, 2) + Math.Pow(y2 - y1, 2));

            int result = lineOneLength.CompareTo(lineTwoLength);
            if (result < 0)
            {
                Console.WriteLine("Line 1 is less than line 2");
            }
            else if (result == 0)
            {
                Console.WriteLine("Line 1 is equal to line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is greater than line 2");
            }
        }
    }
}
