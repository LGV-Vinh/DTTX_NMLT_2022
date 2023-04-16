using System;
namespace Study_Practice
{
    public class Problem_037 : Problem_000
    {
        public Problem_037()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 37: Tính S(n) = CanBac N(N + CanBac N – 1(N – 1 + … + CanBac3(3 + CanBac2(2))) có n – 1 dấu căn");

            // Tao input
            int n = Function.int_in();

            // Tao bien
            double S = 0;

            // Loop
            for (int i = 2; i <= n; i++)
            {
                double temp = S;
                S = Math.Pow(i + temp, (float)1 / i);
            }
            Console.WriteLine($"Bai 037: S({n}) = {S}");
        }
    }
}

