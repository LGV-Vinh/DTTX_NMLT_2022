using System;
namespace Study_Practice
{
    public class Problem_041 : Problem_000
    {
        public Problem_041()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 41: Tính S(n) = 1 / (1 + 1 / ( 1 + 1 / (…. 1 + 1 / 1 + 1))) có n dấu phân số");

            // Input
            int n = Function.Int_In("Nhap so nguyen n:");

            // Variable
            double S = 1;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                double temp = S;
                S = 1 / (1 + temp);
            }
            Console.WriteLine($"S({n}) = {S}.");
        }
    }
}

