﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_LineComparisionProblem
{
    internal class ComparisionOfLines_Usecase3
    {
        public void ComparisonofLines_UC3()
        {
            Console.WriteLine("Please enter the first coordinate x1 :");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the first coordinate y1 :");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the first coordinate x2 :");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the first coordinate y2 :");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("The Length of Line for (" + x1 + "," + y1 + ") and (" + x2 + "," + y2 + ") is : " + length1);

            Console.WriteLine("Please enter the first coordinate x3 :");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the first coordinate y3 :");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the first coordinate x4 :");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the first coordinate y4 :");
            int y4 = Convert.ToInt32(Console.ReadLine());

            double length2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            Console.WriteLine("The Length of Line for (" + x3 + "," + y3 + ") and (" + x4 + "," + y4 + ") is : " + length2);

            //Comparing two lines

            if (length1 == length2)
            {
                Console.WriteLine(" Both the Lines are Equal in length");

            }
            else
            {
                Console.WriteLine(" The Length of Lines are not Equal");

                if (length1 > length2)
                {
                    Console.WriteLine("The Length of Line1 is greater than Line2");
                }
                else
                {
                    Console.WriteLine("The Length of Line2 is greater than Line1");
                }
            }
        }
    }
}