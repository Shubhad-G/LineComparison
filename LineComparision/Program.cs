using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Project");
            float x1,y1, x2, y2;
            float distance;
            //UseCase 1
            Console.WriteLine("Enter the point x1");
            x1=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the point y1");
            y1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the point x2");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the point y2");
            y2=Convert.ToInt32(Console.ReadLine());
           distance = (float)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Distance between two points({0},{1}),({2},{3}) is :{4}", x1,y1,x2,y2,distance);
            //UseCase 2
            Console.WriteLine("enter one more point coordinates to find whether the given two lines are equal or not");

            Console.WriteLine("enter the point z1");
            float z1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the point z2");
            float z2 = Convert.ToInt32(Console.ReadLine());

            if ((x1 / x2 == y1 / y2)
                  && (x1 / x2 == z1 / z2)
                    && (y1 / y2 == z1 / z2))
                Console.WriteLine("The given straight"
                + " lines are identical");

            else
                Console.WriteLine("The given straight"
                    + " lines are not identical");
                    
            Console.ReadLine();
        }
    }
}
