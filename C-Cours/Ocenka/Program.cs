using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocenka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Моля въведете число: ");
            int ocenka = int.Parse(Console.ReadLine());

            switch (ocenka)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Слаба оценка");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Средна оценка");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Добра оценка");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Отлична оценка");
                    break;
                default:
                    Console.WriteLine("Невалидна оценка");
                    break;
            }

            if (1 <= ocenka && ocenka <= 4 )
            {
                Console.WriteLine("Слаба оценка");
            }
            else if (ocenka >= 5 && ocenka <=6)
            {
                Console.WriteLine("Средна оценка");
            }
            else if (ocenka >= 7 && ocenka <= 8)
            {
                Console.WriteLine("Добра оценка");
            }
            else if (ocenka >= 9 && ocenka <= 10)
            {
                Console.WriteLine("Отлична оценка");
            }
            else 
            {
                Console.WriteLine("Невалидна оценка");
            }
        }
    }
}
