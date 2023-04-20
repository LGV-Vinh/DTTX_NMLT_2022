using System;
namespace Study_Practice
{
    public class Problem_002 : Problem_000
    {
        public Problem_002()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 2: Tính S(n) = 1^2 + 2^2 + … + n^2");

            // Tao input
            int n = Function.Int_In("Nhap so nguyen n:");

            // Tao bien
            int S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                S += (i * i);
            }
            Console.WriteLine($"Bai 002: S({n}) = {S}.");
        }
    }
}