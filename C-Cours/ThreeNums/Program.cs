using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int max = 0;
            int avr = 0;
            int min = 0;

            if (num > num1 && num > num2)
            {
                max = num;
                if (num1 > num2)
                {
                    avr = num1;
                    min = num2;
                }
                else
                {
                    avr = num2;
                    min = num1;
                }
            }
            else if (num1 > num && num1 > num2)
            {
                max = num1;

                if (num > num2)
                {
                    avr = num;
                    min = num2;
                }
                else
                {
                    avr = num2;
                    min = num;
                }
            }
            else if (num2 > num && num2 > num1)
            {
                max = num2;

                if (num > num1)
                {
                    avr = num;
                    min = num1;
                }
                else
                {
                    avr = num1;
                    min = num;
                }
            }

            Console.WriteLine($"Максималното числи е: {max}, Средното числи е: {avr}, Минималното число е: {min}");
        }


    }
}
            