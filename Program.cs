using System;

namespace LineComparison
{
    class Program
    {

        /// <summary>
        /// Checkings the equalityof lines.
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        /// <param name="x3">The x3.</param>
        /// <param name="y3">The y3.</param>
        /// <param name="x4">The x4.</param>
        /// <param name="y4">The y4.</param>
        public void CheckingEqualityofLines(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4,double length1 , double length2)
        {
            if(length1.Equals(length2))
            {
                Console.WriteLine("Line1 and Line2 are equal");
            }
            else
            {
                Console.WriteLine("Line1 and Line2 are not equal");  
            }
        }
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        { ///Create a reference of a class
            Program program = new Program();

            Console.WriteLine("Enter the Co-ordinates for x1 and y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-Ordinates for x2 and y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            ///To find the length of the line1
            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The length of line1 is : " + length1);

            Console.WriteLine("Enter the Co-ordinates for x3 and y3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-Ordinates for x4 and y4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());

            ///To find the length of the line2
            double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("The length of line2 is : " + length2);
            ///Checking equality of lines using Equals method
            program.CheckingEqualityofLines(x1, y1, x2, y2, x3, y3, x4, y4, length1, length2);
        }
    }
}
