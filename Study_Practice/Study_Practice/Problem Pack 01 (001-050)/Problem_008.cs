using System;
namespace Study_Practice
{
    public class Problem_008: Problem_000
    {
        public Problem_008()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 8: Tính S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2");

            // Tao input
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            double S = 0;

            // Loop
            for (int i = 0; i <= n; i++)
            {
                double step = (double)(2 * i + 1) / (2 * i + 2);
                S += step;
            }
            Console.WriteLine($"Bai 008: S({n}) = {S}.");
        }
    }
}