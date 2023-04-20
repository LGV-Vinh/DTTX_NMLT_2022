using System;
namespace Study_Practice
{
    public class Problem_067 : Problem_000
    {
        public Problem_067()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 67: Tính S(x, n) = x – x^2 + x^3 + … + (-1)^n+1 * x^n");

            // Input
            int x = Function.Int_In("Nhap so nguyen x:");
            int n = Function.Int_In("Nhap so nguyen n:");

            // Variable
            double sign, term;
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sign = Math.Pow(-1, i + 1);
                term = sign * Math.Pow(x, i);
                sum += term;
            }
            Console.WriteLine(sum);
        }
    }
}

