using System;
namespace Study_Practice
{
    public class Problem_013 : Problem_000
    {
        public Problem_013()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 13: Tính S(n) = x^2 + x^4 + … + x^2n");

            // Tao input
            int x = Function.int_in("Nhap so nguyen x:");
            int n = Function.int_in("Nhap so nguyen n:");

            // Tao bien
            double S, step;
            S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                step = Math.Pow(x, (2 * i));
                S += step;
            }
            Console.WriteLine($"Bai 013: Voi x = {x}, S({n}) = {S}.");
        }
    }
}