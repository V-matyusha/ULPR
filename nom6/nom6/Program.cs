﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace nom6
{
    class Program
    {
        public static void Main()
        {
            int p, k;

            for (int i = 100; i < 1000; i++)
            {
                k = i * i;
                p = (k / 100) % 10 * 100 + (k / 10) % 10 * 10 + k % 10;

                while (i == p)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
