 using System;
using System.Globalization;
namespace n1
{
    class Program
    {
        static void Main()
        {
            DateTime date;
            Console.WriteLine("Введите день:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год:");
            int c = int.Parse(Console.ReadLine());
            int i;
            string date2 = $"{c}, {b}, {a}";

            GregorianCalendar calendar = new GregorianCalendar();
            if (DateTime.TryParse(date2, out date))
            {
                Console.WriteLine("День от начала года: " + calendar.GetDayOfYear(date));
                if (calendar.IsLeapYear(c))
                {
                    i = 366 - calendar.GetDayOfYear(date);

                }
                else
                {
                    i = 365 - calendar.GetDayOfYear(date);
                }
                Console.WriteLine("Дней до конца года: " + i);
            }
            else
            {
                Console.WriteLine("Дата не корректна");
            }
        }
    }
}