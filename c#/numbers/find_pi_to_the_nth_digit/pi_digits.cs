using System;

public class PiDigits
{
	static int MAX = 14;


	public static void Main()
	{
		int n;
		if (int.TryParse (Console.ReadLine(), out n))
		{
			if (n < 1)
			{
				Console.WriteLine ("at least 1 digit");
			}
			else if (n > MAX)
			{
				Console.WriteLine ("can't calculate: too much digits");
			}
			else
			{
				Pi (n);
			}
		}
		else
		{
			Console.WriteLine ("not integer");
		}
	}

	private static void Pi (int n)
	{
		double pi = 0.0d;
		for (int i = 0; i < n; ++i)
		{
			pi += ((Math.Pow (16, -i))) * (((4.0 / (8 * i + 1))) -((2.0 / (8 * i + 4))) - ((1.0 / (8 * i + 5))) - ((1.0 / (8 * i + 6))));
		}
		Console.WriteLine ("{0:N" + n + "}", pi);
	}
}