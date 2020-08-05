using System;

namespace FourComparisonResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1-е число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите 2-е число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("\n" + a + " > " + b + ":  "); Console.WriteLine(a > b);
            Console.Write(a + " < " + b + ":  "); Console.WriteLine(a < b);
            Console.Write(a + " == " + b + ": "); Console.WriteLine(a == b);
            Console.Write(a + " != " + b + ": "); Console.WriteLine(a != b);
            Console.ReadKey();
        }
    }
}