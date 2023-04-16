using System;
namespace Study_Practice
{
    public class Problem_039 : Problem_000
    {
        public Problem_039()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 39: Tính S(n) = CanBac N + 1(N! + CanBacN((N – 1)! + … + CanBac3(2! + CanBac2(1!))) có n dấu căn");

            // Input
            int n = Function.int_in();

            // Tao bien
            double S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                double temp = S;
                S = Math.Pow(Function.Factorial(i) + temp, (float)1 / (i + 1));
            }
            Console.WriteLine($"S({n}) = {S}.");
        }
    }
}

