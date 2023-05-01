using System;
namespace Study_Practice
{
    public class Problem_072 : Problem_000
    {
        public Problem_072()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 72: Tính S(x, n) = – x + x^2/2! – x^3/3! + … + (-1)^n * x^n/n!");

            // Input
            int x = Function.Int_In("Nhap so nguyen x:");
            int n = Function.Int_In("Nhap so nguyen n:");

            // Variable
            double sign, term;
            double sum = 0;

            // Loop for sign and term
            for (int i = 1; i <= n; i++)
            {
                sign = Math.Pow(-1, i);
                term = sign * Math.Pow(x, i) / Function.Factorial(i);
                sum += term;
            }
            Console.WriteLine($"S({x}, {n}) = {sum}.");
        }
    }
}

