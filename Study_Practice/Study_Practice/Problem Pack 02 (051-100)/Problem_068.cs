using System;
namespace Study_Practice
{
    public class Problem_068 : Problem_000
    {
        public Problem_068()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 68: Tính S(x, n) = -x^2 + x^4  + … + (-1)^n * x^2n");

            // Input
            int x = Function.Int_In("Nhap so nguyen x:");
            int n = Function.Int_In("Nhap so nguyen n:");

            // Variable
            double sign, term;
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sign = Math.Pow(-1, i);
                term = sign * Math.Pow(x, 2 * i);
                sum += term;
            }
            Console.WriteLine($"S({x}, {n}) = {sum}.");
        }
    }
}

