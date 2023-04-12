using System;
namespace Study_Practice
{
    public class Problem_015 : Problem_000
    {
        public Problem_015()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 15: Tính S(n) = 1 + 1/1 + 2 + 1/ 1 + 2 + 3 + ….. + 1/ 1 + 2 + 3 + …. + N");

            // Tao input
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            double S, step;
            S = 0;
            step = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                step += i;
                S += (double)1 / step;
            }
            Console.WriteLine($"Bai 015: S({n}) = {S}.");
        }
    }
}

