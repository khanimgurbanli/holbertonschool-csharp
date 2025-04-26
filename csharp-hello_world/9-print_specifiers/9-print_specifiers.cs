using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = 0.2641;
        double currency = 12345.6789;
        Console.WriteLine($"Percent: {percent:P2}\nCurrency: {currency.ToString("C2", CultureInfo.GetCultureInfo("en-US"))}");
    }
}
