using System;
namespace Study_Practice
{
    public class Problem_016 : Problem_000
    {
        public Problem_016()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 16: Tính S(n) = x + x^2/1 + 2 + x^3/1 + 2 + 3 + … + x^n/1 + 2 + 3 + …. + N");

            // Tao input
            int x = Function.Int_In("Nhap so nguyen x:");
            int n = Function.Int_In("Nhap so nguyen n:");

            // Tao bien
            double S = 0;
            int step = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                step += i;
                S += Math.Pow(x, i) / step;
            }
            Console.WriteLine($"Bai 016: Voi x = {x}, S({n}) = {S}.");
        }
    }
}

