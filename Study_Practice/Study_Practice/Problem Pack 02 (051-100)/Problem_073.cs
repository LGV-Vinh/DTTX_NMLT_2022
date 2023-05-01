using System;
namespace Study_Practice
{
    public class Problem_073 : Problem_000
    {
        public Problem_073()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 73: Tính S(x, n) = -1 + x^2/2! – x^4/4! + … + (-1)^n+1 * x^2n/(2n)!");

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
                term = sign * Math.Pow(x, 2 * i) / Function.Factorial(2 * i);
                sum += term;
            }
            Console.WriteLine($"S({x}, {n}) = {sum}.");
        }
    }
}

