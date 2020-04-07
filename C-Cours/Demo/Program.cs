using System;
using System.Diagnostics;

namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CalculateHouseArea());
            //Console.WriteLine("Hello");

            //Console.WriteLine("What is the car price");

            //decimal carPrice = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("What is your monthly income");

            //decimal monthlyIncome = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("What are your monthly expenses");

            //decimal monthlyExpenses = decimal.Parse(Console.ReadLine());

            //decimal months = CalculateNeededMonthsToBuyCar(carPrice, monthlyIncome, monthlyExpenses);

            //Console.WriteLine($"You will be able to buy this car after {Math.Ceiling(months)} months");

            int n = int.Parse(Console.ReadLine());

            var watch = new Stopwatch();

            watch.Start();
            Console.WriteLine(CalcFactR(n));
            watch.Stop();
            Console.WriteLine(watch.Elapsed);

            watch.Start();
            Console.WriteLine(CalcFact(n));
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
        }

        private static int CalcFact(int n)
        {
            int result = n;
            for (int i = n - 1; i >= 1; i--)
            {
                result = result * i;
            }

            return result;
        }

        private static int CalcFactR(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return n * CalcFactR(n - 2);
            }
            else
            {
                return n * CalcFactR(--n);
            }
        }

        public static decimal CalculateNeededMonthsToBuyCar(decimal price, decimal income, decimal expenses)
        {
            income = income - income * 0.10m;

            price = price * 1.2m;

            decimal savings = income - expenses - 200;

            decimal months = price / savings;

            return months;
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

        public static double GetRectangleArea()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = a * b;

            return area;
        }

        public static double GetRectangleArea(double sideA, double sideB)
        {
            double area = sideA * sideB;

            return area;
        }

    }
}
