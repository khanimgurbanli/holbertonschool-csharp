using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = Convert.ToDouble(Console.ReadLine());
        double currency = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Percent: {0:P2}", percent);
        Console.WriteLine("Currency: ${0:N2}", currency);
    }
}
