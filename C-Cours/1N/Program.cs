﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Моля въведете число: ");
            var N = int.Parse(Console.ReadLine());

            for (int i = 1; i < N; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
