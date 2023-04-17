using System;
namespace Study_Practice
{
    public class Problem_019 : Problem_000
    {
        public Problem_019()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 19: Tính S(n) = 1 + x + x^3/3! + x^5/5! + … + x^(2n+1)/(2n+1)!");

            // Tao input
            int x = Function.int_in("Nhap so nguyen x:");
            int n = Function.int_in("Nhap so nguyen n:");

            // Tao bien
            double S = 1;

            // Loop
            for (int i = 0; i <= n; i++)
            {
                S += Math.Pow(x, (2 * i + 1)) / Function.Factorial(2 * i + 1);
            }
            Console.WriteLine($"Bai 019: Voi x = {x}, S({n}) = {S}.");
        }
    }
}