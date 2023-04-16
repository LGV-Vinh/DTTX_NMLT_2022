using System;
namespace Study_Practice
{
    public class Problem_036 : Problem_000
    {
        public Problem_036()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 36: Tính S(n) = CanBac2(n! + CanBac2((n-1)! +CanBac2((n – 2)! + … + CanBac2(2!) + CanBac2(1!)))) có n dấu căn");


            // Tao input
            Console.WriteLine("Nhap so n");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            double S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                double temp = S;
                S = Math.Sqrt(Function.Factorial(i) + temp);
            }
            Console.WriteLine($"Bai 036: S({n}) = {S}.");
        }
    }
}

