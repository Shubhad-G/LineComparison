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
            Console.ReadLine();
            int x1, y1, x2, y2;
            float distance;

            Console.WriteLine("Enter the point x1");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the point y1");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the point x2");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the point y2");
            y2 = Convert.ToInt32(Console.ReadLine());
            distance = (float)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Distance between two points({0},{1}),({2},{3}) is :{4}", x1, y1, x2, y2, distance);
            Console.ReadLine();
        }
    }
}
