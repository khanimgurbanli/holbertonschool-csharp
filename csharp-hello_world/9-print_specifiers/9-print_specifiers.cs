using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = 0.2641;
        double currency = 12345.6789;
        Console.WriteLine("Percent: {0:P2}", percent);
        Console.WriteLine("Currency: ${0:N2}", currency);
    }
}
