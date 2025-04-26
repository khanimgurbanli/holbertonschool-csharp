using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = double.Parse(args[0]);
        double currency = double.Parse(args[1]);
        Console.WriteLine("Percent: {0:P2}", percent);
        Console.WriteLine("Currency: ${0:N2}", currency);
    }
}
