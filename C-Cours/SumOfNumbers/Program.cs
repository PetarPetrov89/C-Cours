using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = 0;
            int basket = 0;
            Console.Write("Моля въведете число: ");
            number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                basket += number;
                Console.Write("Моля въведете следващо число: ");
                number = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"Сумата на числата е равна на: {basket}");
        }
    }
}
