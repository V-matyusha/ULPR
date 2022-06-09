using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class program
{
    public static void Main()
    {
        int j;
        int i = 0;
        Console.WriteLine("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());

        while (i < n)
        {
            j = i * i;

            if (j > n)
            {
                Console.WriteLine($"Квадрат {i} = {j} больше {n}");
                break;
            }
            i++;
        }
    }
}
