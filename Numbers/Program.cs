using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            c = a * b;
            Console.WriteLine(c);

            c = a - b;
            Console.WriteLine(c);

            c = a / b;
            Console.WriteLine(c);

            a = 5;
            b = 4;
            c = 2;

            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            int e = (a + b) % c;

            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"The range of integers in {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");


        }
    }
}

