﻿using System;
namespace nom1
{
    class Program
    {
        public static void Main()
        {
            int v = 0;
            Console.WriteLine("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            v = a * b * c;
            Console.WriteLine("Объём параллелепипеда = " +v);
        }
    }
}
