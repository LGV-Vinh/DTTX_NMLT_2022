using System;
namespace Study_Practice
{
    public class Problem_005 : Problem_000
    {
        public Problem_005()
        {
        }
        public override void Solution()
        {
            // Bài 5: Tính S(n) = 1 + 1/3 + 1/5 + … + 1/(2n + 1)
            // Tao input
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            double S = 0;

            // Loop
            for (int i = 0; i <= n; i++)
            {
                double step = 1 / (double)(2 * i + 1);
                S += step;
            }
            Console.WriteLine($"Bai 005: S({n}) = {S}.");
        }
    }
}

