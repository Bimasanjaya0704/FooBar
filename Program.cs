using System.Diagnostics;
using System.Text;

public class FooBar
{
	public static bool Foo(int n)
	{
		return n % 3 == 0;
	}

	public static bool Bar(int n)
	{
		return n % 5 == 0;
	}

	public static void FooAndBar(int n)
	{
		StringBuilder s = new();
		for (int i = 0; i <= n; i++)
		{
			bool isShow = true;
			if (i != 0 & Foo(i) && Bar(i))
			{
				s.Append("Foobar");
				isShow = false;
			}
			else if (i != 0 && Foo(i))
			{
				s.Append("Foo");
				isShow = false;
			}
			else if (i != 0 && Bar(i))
			{
				s.Append("Bar");
				isShow = false;
			}
			if (isShow)
			{
				s.AppendLine(i.ToString());
			}
			else
			{
				s.AppendLine();
			}

		}
		Console.WriteLine(s.ToString());
	}

	static void Main()
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		int n = 15;
		FooAndBar(n);
		stopwatch.Stop();
		Console.WriteLine($"Time : {stopwatch.ElapsedMilliseconds} ms");
	}
}
