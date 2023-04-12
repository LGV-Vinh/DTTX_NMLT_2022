using System;
namespace Study_Practice
{
    public class Problem_006 : Problem_000
    {
        public Problem_006()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 6: Tính S(n) = 1/1×2 + 1/2×3 +…+ 1/n x (n + 1)");

            // Tao input
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            double S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                double step = 1 / (double)(i * (i + 1));
                S += step;
            }
            Console.WriteLine($"Bai 006: S({n}) = {S}.");
        }
    }
}