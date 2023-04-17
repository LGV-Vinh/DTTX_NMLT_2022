using System;
namespace Study_Practice
{
    public class Problem_034 : Problem_000
    {
        public Problem_034()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 34: Tính S(n) = CanBac2(n+CanBac2(n – 1 + CanBac2( n – 2 + … + CanBac2(2 + CanBac2(1)  có n dấu căn");

            // Tao input
            int n = Function.int_in("Nhap so nguyen n:");

            // Tao bien
            double S = 0;

            for (int i = 1; i <= n; i++)
            {
                double temp = S;
                S = Math.Sqrt(i - temp);
            }
            Console.WriteLine($"Bai 034: S({n}) = {S}.");
        }
    }
}

