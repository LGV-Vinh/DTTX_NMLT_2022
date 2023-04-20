using System;
namespace Study_Practice
{
    public class Problem_012 : Problem_000
    {
        public Problem_012()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 12: Tính S(n) = x + x^2 + x^3 + … + x^n");

            // Tao input
            int x = Function.Int_In("Nhap so nguyen x:");
            int n = Function.Int_In("Nhap so nguyen n:");

            // Tao bien
            double S = 0;
            double step = 0;

            // Loop
            for (int i = 0; i <= n; i++)
            {
                step = Math.Pow(x, i);
                S += step;
            }
            Console.WriteLine($"Bai 012: Voi x = {x}, S({n}) = {S}.");
        }
    }
}