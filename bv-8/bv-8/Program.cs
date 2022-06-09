using System;
namespace n5
{
	class Program
	{
		static void Main()
		{
			int[] mass = new int[10];
			Random rand = new Random();
			for (int i = 0; i < mass.Length; i++)
			{
				int a = rand.Next(1, 100);
				mass[i] = a;
				Console.WriteLine(mass[i]);
			}
			for (int i = mass.Length - 1; i >= 0; i--)
			{
				int a = rand.Next(i);
				int b = mass[i];
				mass[i] = mass[a];
				mass[a] = b;
			}
			Console.WriteLine(" ");
			for (int i = 0; i < mass.Length; i++)
			{
				Console.WriteLine(mass[i]);
			}
		}
	}
}
