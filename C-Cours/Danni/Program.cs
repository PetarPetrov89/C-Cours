using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете потребителско име: ");
            string username = Console.ReadLine();
            Console.Write("Въведете електронна поща: ");
            string mail = Console.ReadLine();
            Console.Write("Въведете телефонен номер: ");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Въведете години: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Вие въведохте потребителско име {username}, " +
                $"неговата електронна поща е {mail}. Потрбителя е на {age} години, " +
                $"неговият телефонен номер е {phoneNumber}.");
        }
    }
}
