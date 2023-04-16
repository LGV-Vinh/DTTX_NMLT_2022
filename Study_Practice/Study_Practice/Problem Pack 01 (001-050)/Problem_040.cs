using System;
namespace Study_Practice
{
    public class Problem_040 : Problem_000
    {
        public Problem_040()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 40: Tính S(n) = CanBac2(x^n + CanBac2(x^n-1 + … + CanBac2(x^2 + CanBac2(x)))) có n dấu căn");

            // Input
            int n = Function.int_in();
            int x = Function.int_in("Nhap so x:");

            // Variable
            double S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                double temp = S;
                S = Math.Sqrt(Math.Pow(x, i) + temp);
            }
            Console.WriteLine($"S({n}) = {S}.");
        }
    }
}

