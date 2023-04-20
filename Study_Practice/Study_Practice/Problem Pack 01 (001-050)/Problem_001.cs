using System;
namespace Study_Practice
{
    public class Problem_001 : Problem_000
    {
        public Problem_001()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 1: Tính S(n) = 1 + 2 + 3 + … + n");

            // Tao input
            int n = Function.Int_In("Nhap so nguyen n:");

            // Tao bien
            int S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                S += i;
            }
            Console.WriteLine($"Bai 001: S({n}) = {S}.");
        }
    }
}