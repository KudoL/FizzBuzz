﻿using System;

namespace Fizzbuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0)
				{
					if (i % 5 == 0)
					{
						Console.WriteLine("FizzBuzz");
						continue;
					}
					Console.WriteLine("Fizz");
					continue;
				}
				if (i % 5 == 0)
				{
					Console.WriteLine("Buzz");
					continue;
				}
				Console.WriteLine(i);
			}
			Console.ReadLine();
		}
	}
}
