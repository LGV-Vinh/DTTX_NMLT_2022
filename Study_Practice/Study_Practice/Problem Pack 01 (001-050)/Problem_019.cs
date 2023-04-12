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

            static int Factorial(int n) // Tao function tinh factorial cua so duoc nhap
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
            // Tao input
            Console.WriteLine("Nhap so nguyen x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            double S = 1;

            // Loop
            for (int i = 0; i <= n; i++)
            {
                S += Math.Pow(x, (2 * i + 1)) / Factorial(2 * i + 1);
            }
            Console.WriteLine($"Bai 019: Voi x = {x}, S({n}) = {S}.");
        }
    }
}