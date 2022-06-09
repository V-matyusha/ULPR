using System;
using System.Globalization;
namespace n2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите день:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год:");
            int c = int.Parse(Console.ReadLine());
            DateOnly julianDate = new DateOnly(c, b, a, new JulianCalendar());
            Console.WriteLine("Дата по грегорианскому календарю: " + julianDate);
        }
    }
}