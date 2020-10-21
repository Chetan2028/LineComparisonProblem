using System;

namespace LineComparison
{
    class Program
    {
        ///Variable
        double length = 0;
        /// <summary>
        /// To Calculate the Length the of the line.
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        public void LengthOfTheLine(int x1 , int y1, int x2, int y2)
        {
            length = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
            Console.WriteLine("Length of the line : " + length);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Co-ordinates for x1 and y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-Ordinates for x2 and y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            Program program = new Program();
            program.LengthOfTheLine(x1,y1,x2,y2);
        }
    }
}
