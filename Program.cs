﻿namespace LineComparison
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to line computation program.");

            //Taking line points from user
            Console.WriteLine("Enter the line co-ordinates as x1,y1,x2,y2: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the line co-ordinates as a1,b1,a2,b2: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());

            //Calling Length of line function
            CompareTwoLines lineComparison = new CompareTwoLines();
            lineComparison.LengthOfLine(x1, y1, x2, y2, a1, b1, a2, b2);
        }
    }
}