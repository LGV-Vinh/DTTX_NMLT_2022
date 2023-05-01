using System;
namespace Study_Practice
{
    public class Problem_071 : Problem_000
    {
        public Problem_071()
        {
        }

        public override void Solution()
        {
            Console.WriteLine("Bài 71: Tính S(x, n) = -x + x^2/(1 + 2) – x^3/(1 + 2 + 3) + … + (-1)^n * x^n/(1 + 2 +… + n)");

            // Input
            int x = Function.Int_In("Nhap so nguyen x:");
            int n = Function.Int_In("Nhap so nguyen n:");

            // Variable
            double sign, term;
            int step = 0;
            double sum = 0;

            // Loop for sign and term
            for (int i = 1; i <= n; i++)
            {
                sign = Math.Pow(-1, i);
                step += i;
                term = sign * Math.Pow(x, i) / step;
                sum += term;
            }
            Console.WriteLine($"S({x}, {n}) = {sum}.");
        }
    }
}

