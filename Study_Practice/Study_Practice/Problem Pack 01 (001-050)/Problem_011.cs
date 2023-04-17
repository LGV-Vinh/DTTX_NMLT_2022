using System;
namespace Study_Practice
{
    public class Problem_011 : Problem_000
    {
        public Problem_011()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 11: Tính S(n) = 1 + 1.2 + 1.2.3 + … + 1.2.3….N");

            // Tao input
            int n = Function.int_in("Nhap so nguyen n:");

            // Tao bien
            int S = 0;
            int step = 1;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                step *= i;
                S += step;
            }
            Console.WriteLine($"Bai 011: S({n}) = {S}.");
        }
    }
}