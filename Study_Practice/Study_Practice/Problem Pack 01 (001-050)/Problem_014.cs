using System;
namespace Study_Practice
{
    public class Problem_014 : Problem_000
    {
        public Problem_014()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 14: Tính S(n) = x + x^3 + x^5 + … + x^2n + 1");

            // Tao input
            Console.WriteLine("Nhap so nguyen x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            double S, step;
            S = 0;

            // Loop
            for (int i = 0; i <= n; i++)
            {
                step = Math.Pow(x, (2 * i + 1));
                S += step;
            }
            Console.WriteLine($"Bai 014: Voi x = {x}, S({n}) = {S}.");
        }
    }
}