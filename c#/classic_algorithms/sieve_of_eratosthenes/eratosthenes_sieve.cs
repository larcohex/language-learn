using System;
using System.Collections.Generic;

public class EratosthenesSieve
{
	static List <int> primes = new List <int>();

	public static void Main()
	{
		Console.WriteLine ("Please wait");
		GeneratePrimes();
		for (int i = 0; i < primes.Count; ++i)
		{
			Console.WriteLine (primes[i]);
		}
	}

	private static void GeneratePrimes()
	{
		bool[] p = new bool[10000];
		p[0] = p[1] = true;
		for (int i = 1; i < 10000; ++i)
		{
			for (int j = 2; j <= Math.Sqrt (i); ++j)
			{
				if (!p[j] && i % j == 0)
				{
					p[i] = true;
					break;
				}
			}
			if (!p[i])
			{
				primes.Add (i);
			}
		}
	}
}