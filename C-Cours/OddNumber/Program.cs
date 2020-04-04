using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Моля въведете число: ");
            int number = int.Parse(Console.ReadLine());

            var even = (number % 2);

            if (even != 0)
            {
                int result = (number * 2);
                Console.WriteLine($"Резултата е: {result}");
            }
            else
            {
                Console.WriteLine("Въвели сте четно число.");
                
            }

          
        }
    }
}
