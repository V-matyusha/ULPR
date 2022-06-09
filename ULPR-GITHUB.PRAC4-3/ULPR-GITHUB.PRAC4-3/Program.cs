using System;
using System.Globalization;
namespace n3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            for (int month = 1; month < 12; month++)
            {
                DateTime date = new DateTime(year, month, DateTime.DaysInMonth(year, month));
                Console.WriteLine($"{date.Day - (7 + (int)date.DayOfWeek - 4) % 7} число - последний четверг {date.Month}-го месяца {year} года.");
            }
        }
    }
}
