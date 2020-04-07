using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            GetRectangleArea();
            Console.WriteLine("Край");
        }




            public static void GetRectangleArea()
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                double area = a * b;

                Console.WriteLine(area);
            
            }
       
        }
    }

