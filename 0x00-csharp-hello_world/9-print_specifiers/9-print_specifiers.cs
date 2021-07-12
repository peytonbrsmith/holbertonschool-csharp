using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine("percent: {0:0.00%}", percent);
        Console.WriteLine("currency: {0}", currency.ToString("C"));
	}
}