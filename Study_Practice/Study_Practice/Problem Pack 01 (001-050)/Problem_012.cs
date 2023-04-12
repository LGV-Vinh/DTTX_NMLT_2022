using System;
namespace Study_Practice
{
    public class Problem_012 : Problem_000
    {
        public Problem_012()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 12: Tính S(n) = x + x^2 + x^3 + … + x^n");

            // Tao input
            Console.WriteLine("Nhap so nguyen x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            double S = 0;
            double step = 0;

            // Loop
            for (int i = 0; i <= n; i++)
            {
                step = Math.Pow(x, i);
                S += step;
            }
            Console.WriteLine($"Bai 012: Voi x = {x}, S({n}) = {S}.");
        }
    }
}

