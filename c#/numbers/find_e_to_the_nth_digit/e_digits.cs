using System;

public class EDigits
{
	public static void Main()
	{
		int n;
		if (int.TryParse (Console.ReadLine(), out n))
		{
			if (n < 1)
			{
				Console.WriteLine ("at least 1 digit");
			}
			else
			{
				E (n);
			}
		}
		else
		{
			Console.WriteLine ("not integer");
		}
	}

	private static void E (int n)
	{
		string e = "2.";
		int[] q = new int[n + 1];
		int[] r = new int[n + 1];
		for (int i = 0; i < n + 1; ++i)
		{
			r[i] = 1;
		}
		for (int i = 0; i < n - 1; ++i)
		{
			for (int j = 0; j < n + 1; ++j)
			{
				r[j] *= 10;
			}
			for (int j = n; j > 0; --j)
			{
				q[j] = r[j] / (j + 2);
				r[j - 1] += q[j];
				r[j] %= j + 2;
			}
			q[0] = r[0] / 2;
			r[0] %= 2;
			e += q[0].ToString();
		}
		Console.WriteLine (e.Substring (0, n + 1));
	}
}