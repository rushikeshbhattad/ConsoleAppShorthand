using System;

namespace ShorthandOperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = 3;
            a %= b;
            Console.WriteLine("a= " + a);
            a = 3;
            b = 2;
            a *= 2;
            Console.WriteLine("a= " + a);
            a = 27;
            b = 3;
            a /= b;
            Console.WriteLine("a= " + a);
            a = 97;
            b = 89;
            a -= b;
            Console.WriteLine("a= " + a);
            a = 97;
            b = 107;
            a -= b;
            Console.WriteLine("a= " + a);
            Console.ReadKey();
        }
    }
}