using System;

namespace Line_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation Problem");
            //initialising coordinates as integers
            int a1, a2, b1, b2;
            double length;
            Console.WriteLine("Enter a-coordinate of First Point:");
            //converting into integer using ToInt32
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b-coordinate of First Point:");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a-coordinate of Second Point:");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b-coordinate of Second Point:");
            b2 = Convert.ToInt32(Console.ReadLine());
            //formula for calculate length
            length = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            Console.WriteLine(length);
        }
    }
}
