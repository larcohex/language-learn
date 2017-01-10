using System;
using System.Collections.Generic;

public class NextPrime
{
	static List <int> primes = new List <int>();
	static int current = 2;

	public static void Main()
	{
		Console.WriteLine ("Please wait");
		Console.Write ("Press ENTER to show next prime, Q to exit.");
		ConsoleKeyInfo keyInfo;
		do
		{
			keyInfo = Console.ReadKey();
			if (keyInfo.Key == ConsoleKey.Enter)
			{
				PrintNextPrime();
			}
		}
		while (keyInfo.Key != ConsoleKey.Q);
	}

	private static void PrintNextPrime()
	{
		bool loop = true;
		while (loop)
		{
			bool isPrime = true;
			for (int i = 0; i < primes.Count; ++i)
			{
				if (primes[i] <= Math.Sqrt (current))
				{
					if (current % primes[i] == 0)
					{
						isPrime = false;
						break;
					}
				}
				else
				{
					break;
				}
			}
			if (isPrime)
			{
				Console.Write (current);
				primes.Add (current);
				loop = false;
			}
			++current;
		}
	}
}