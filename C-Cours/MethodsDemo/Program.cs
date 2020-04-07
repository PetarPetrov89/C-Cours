using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateHouseArea());
            Console.WriteLine("Final");
        }
        private static double CalculateHouseArea()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            //Calcualte RectangleArea
            double calculatedRectangleArea = GetRectangleArea(a, b);


            //Calcualte triangle area
            double triangleSide = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double calculatedTriangleArea = GetTriangleArea(triangleSide, height);

            double figureArea = calculatedRectangleArea + calculatedTriangleArea;

            return figureArea;
        }

        private static double GetTriangleArea(double triangleSide, double height)
        {
            double area = triangleSide * height / 2;

            return area;
        }

        public static double GetRectangleArea(double sideA, double sideB)
        {
            double area = sideA * sideB;

            return area;
        }
    }
}
