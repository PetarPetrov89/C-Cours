using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplay5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterOfNegativeNumbers = 0;

            for (int i = 0; i < 5; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    counterOfNegativeNumbers++;
                }
                else if (num == 0)
                {
                    Console.WriteLine("The result is zero");
                    return;
                }
            }
                if (counterOfNegativeNumbers % 2 == 0)
                {
                    Console.WriteLine("Positive");
                }
                else
                {
                    Console.WriteLine("Negative");
                }
            
        }
    }
}
