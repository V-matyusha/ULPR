﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace nom2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine($"Введите x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введите y: ");
            int y = int.Parse(Console.ReadLine());

            if (x >= -1)
            {
                Console.WriteLine($"x: {x} Подходит");
            }
            else
            {
                Console.WriteLine($"x: {x} Не подходит");
            }

            if (y >= -1)
            {
                Console.WriteLine($"y: {y} Подходит");
            }
            else
            {
                Console.WriteLine($"y: {y} Не подходит");
            }

            if (y >= -1 && x >= -1)
            {
                Console.WriteLine($"Точка ({x}, {y}) принадлежит области, указанной на рис.");
            }
            else
            {
                Console.WriteLine($"Точка ({x}, {y}) не принадлежит области, указанной на рис.");
            }
        }
    }
}
