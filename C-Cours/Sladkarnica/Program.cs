using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sladkarnica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Моля въведете броя дни: ");
            int days = int.Parse(Console.ReadLine());
            Console.Write("Моля въведете броя на сладкарите: ");
            int cookers = int.Parse(Console.ReadLine());
            Console.Write("Моля въведете броя на тортите: ");
            int cakes = int.Parse(Console.ReadLine());
            Console.Write("Моля въведете броя на гофретите: ");
            int gofreti = int.Parse(Console.ReadLine());
            Console.Write("Моля въведете броя на палачинките: ");
            int pancake = int.Parse(Console.ReadLine());

            double moneycakes = cakes * 45;
            double moneygofreti = gofreti * 5.80;
            double moneypancakes = pancake * 3.20;

            double moneyday = (moneycakes + moneygofreti + moneypancakes) * cookers;
            double moneyall = moneyday * days;

            double final = moneyall - (moneyall / 8);

            Console.WriteLine("Сумата на събраните средства е:" + " " + "{0:f2}", final);
        }
    }
}