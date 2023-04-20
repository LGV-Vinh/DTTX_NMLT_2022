using System;
namespace Study_Practice
{
    public class Problem_069 : Problem_000
    {
        public Problem_069()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 69: Tính S(x, n) = x – x^3 + x^5 + … + (-1)^n * x^2n+1");

            // Input
            int x = Function.Int_In("Nhap so nguyen x:");
            int n = Function.Int_In("Nhap so nguyen n:");

            // Variable
            double sign, term;
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sign = Math.Pow(-1, i);
                term = sign * Math.Pow(x, 2 * i + 1);
                sum += term;
            }
            Console.WriteLine($"S({x}, {n}) = {sum}.");
        }
    }
}

