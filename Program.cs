using System;

namespace LineComparison
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ///Create a reference of a class
            Program program = new Program();

            Console.WriteLine("Enter the Co-ordinates for x1 and y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-Ordinates for x2 and y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            ///To find the length of the line
            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The length of line1 is : " + length1);
        }
    }
}
