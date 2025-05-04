using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int num = number % 10;
        if (num < 0)
        {
            num *= -1;
        }
        Console.Write("{0}", num);
        return num;
    }
}

