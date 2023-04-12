using System;
namespace Study_Practice
{
    public class Problem_017 : Problem_000
    {
        public Problem_017()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 17: Tính S(n) = x + x^2/2! + x^3/3! + … + x^n/N!");

            // Tao input
            Console.WriteLine("Nhap so nguyen x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            double S = 0;
            double step = 1;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                step *= i;
                S += Math.Pow(x, i) / step;
            }
            Console.WriteLine($"Bai 017: Voi x = {x}, S({n}) = {S}.");
        }
    }
}