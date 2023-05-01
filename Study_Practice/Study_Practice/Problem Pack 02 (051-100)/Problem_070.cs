using System;
namespace Study_Practice
{
    public class Problem_070 : Problem_000
    {
        public Problem_070()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 70: Tính S(n) = 1 – 1/(1 + 2) + 1/(1 + 2 + 3)  + … + (-1)^n+1 * 1/(1 + 2 + 3+ … + n)");

            // Input
            int n = Function.Int_In("Nhap so nguyen n");

            // Variable
            double sign, term;
            int step = 0;
            double sum = 0;

            // Loop for sign and term
            for (int i = 1; i <= n; i++)
            {
                step += i;
                sign = Math.Pow(-1, i + 1);
                term = sign * (1.0 / step);
                sum += term;
            }
            Console.WriteLine($"S({n}) = {sum}.");
        }
    }
}

