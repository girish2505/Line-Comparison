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
            //Checking line1 equals line 2 by Equals() and ternary operator 
            String result = lineOneLength.Equals(lineTwoLength) ? "Line one is equal to line Two" : "Line one is not equal to line Two";
            Console.WriteLine(result);
        }
    }
}
