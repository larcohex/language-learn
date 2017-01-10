using System;

public class Fibonacci
{
	public static void Main()
	{
		Console.WriteLine ("NOTE: Fibonacci sequence in this app starts with 0 1");
		int n;
		if (int.TryParse (Console.ReadLine(), out n))
		{
			if (n < 1)
			{
				Console.WriteLine ("at least 1 digit");
			}
			else
			{
				Fib (n);
			}
		}
		else
		{
			Console.WriteLine ("not integer");
		}
	}

	public static void Fib (int n)
	{
		int[] fib = new int[n > 2 ? n : 2];
		fib[0] = 0;
		fib[1] = 1;
		for (int i = 2; i < n; ++i)
		{
			fib[i] = fib[i - 2] + fib[i - 1];
		}
		Console.Write (fib[0]);
		for (int i = 1; i < n; ++i)
		{
			Console.Write (" " + fib[i].ToString());
		}
		Console.Write ("\n");
	}
}