﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());

            double BGR = USD * 1.79549;

            Console.WriteLine($"{BGR:f2}");
        }
    }
}

