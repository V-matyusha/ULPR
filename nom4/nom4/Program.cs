﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nom4
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            for (int i = 1; i <= n; i++)
            {
                m *= n % 10;
                n = n / 10;
            }
            Console.WriteLine($"Произведение: { m} ");
        }
    }
}
