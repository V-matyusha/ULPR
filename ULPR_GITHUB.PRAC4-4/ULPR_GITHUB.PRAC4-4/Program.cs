﻿using System;

namespace n4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество попыток n: ");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int i = rnd.Next(1, n);
            int k = rnd.Next(5, n);
            bool isWin = false;
            while (k > 0 & isWin == false)
            {
                Console.WriteLine($"У вас {k} попыток");
                int m = int.Parse(Console.ReadLine());

                if (m == i)
                {
                    Console.WriteLine("Вы угадали!");
                    isWin = true;
                }
                else
                {
                    if (m > i)
                    {
                        Console.WriteLine("Число меньше\n");
                    }
                    else
                    {
                        Console.WriteLine("Число больше\n");
                    }
                    k -= 1;
                }
            }
            if (k <= 0)
            {
                Console.WriteLine("------------------------------------------- \nПопытки закончились");
            }
            Console.ReadKey();
        }
    }
}