using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputationProblem
{
    internal class LineComparisionProblem_UseCase1
    {
        public static void LineComparisionProblemUC1()
        {
            Console.WriteLine("Please enter the first coordinate x1 :");
            int x1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Please enter the first coordinate y1 :");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the first coordinate x2 :");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the first coordinate y2 :");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("The Length of Line for (" + x1 + "," + y1 + ") and (" + x2 + "," + y2 + ") is : " + length);
        }
    }
}
