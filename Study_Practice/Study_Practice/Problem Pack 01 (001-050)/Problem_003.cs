using System;
namespace Study_Practice
{
    public class Problem_003 : Problem_000
    {
        public Problem_003()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 3: Tính S(n) = 1 + ½ + 1/3 + … + 1/n");

            // Tao input
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            double S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                double step = 1 / (double)i;
                S += step;
            }
            Console.WriteLine($"Bai 003: S({n}) = {S}.");
        }
    }
}