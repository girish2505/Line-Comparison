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

            double Length_of_first_Line = FindLength(a1, b2, a1, b2);

            double Length_of_second_Line = FindLength(x1, y2, x1, y2);

            Console.WriteLine("\nFirst line length is : " + Length_of_first_Line);

            Console.WriteLine("\nSecond line length is : " + Length_of_second_Line);

            if (Length_of_first_Line.Equals(Length_of_second_Line))
            {
                Console.WriteLine("\nBoth Lines Are Equal");
            }
            else
            {
                Console.WriteLine("\nBoth Lines Are Not Equal");
            }
            switch (Length_of_first_Line.CompareTo(Length_of_second_Line))
            {
                case 1:
                    Console.WriteLine("\nFirst Line Is Greater Than Second Line");
                    break;
                case -1:
                    Console.WriteLine("\n Second Line Is Greater Than First Line");
                    break;
                default:
                    Console.WriteLine("\nBoth  Lines are Equal");
                    break;
            }
        }
        private static double FindLength(int a1, int a2, int b1, int b2)
        {
            return Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
        }
    }
}
