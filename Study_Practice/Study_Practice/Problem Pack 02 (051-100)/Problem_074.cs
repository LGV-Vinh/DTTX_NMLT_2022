using System;
namespace Study_Practice
{
    public class Problem_074 : Problem_000
    {
        public Problem_074()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 74: Tính S(x, n) = 1 – x + x^3/3! – x^5/5! + … + (-1)^n+1 * x^2n+1/(2n + 1)!");

            // Input
            int x = Function.Int_In("Nhap so nguyen x:");
            int n = Function.Int_In("Nhap so nguyen n:");

            // Variable
            double sign, term;
            double sum = 0;

            // Loop for sign and term
            for (int i = 1; i <= n; i++)
            {
                sign = Math.Pow(-1, i + 1);
                term = sign * Math.Pow(x, 2 * i + 1) / Function.Factorial(2 * i + 1);
                sum += term;
            }
            Console.WriteLine($"S({x}, {n}) = {sum}.");
        }
    }
}

