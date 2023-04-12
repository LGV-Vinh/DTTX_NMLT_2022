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
            Console.WriteLine("Nhap so nguyen x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

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

