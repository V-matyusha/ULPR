﻿using System;
namespace nom3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите сколько чисел будет в массиве");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            int sum = 0;
            int sum1;
            for (int i = 0; i < n; i++)
            {
                int r = new Random().Next(1, 1000);
                mas[i] = r;
                Console.WriteLine(mas[i]);
            }
            for (int i = 0; i< n ; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + Math.Abs(mas[i]);
                }
            }
            Console.WriteLine($"Сумма нечётных чисел = { sum}");
            sum1 = Math.Abs(mas[0]) + Math.Abs(mas[n - 1]);
            Console.WriteLine($"Сумма крайних чисел = { sum1}");
            if (sum > sum1)
            {
                Console.WriteLine("\n" +sum);
            }
        }
    }
}
