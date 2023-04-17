using System;
namespace Study_Practice
{
    public class Problem_018 : Problem_000
    {
        public Problem_018()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 18: Tính S(n) = 1 + x^2/2! + x^4/4! + … + x^2n/(2n)!");

            // Tao input
            int x = Function.int_in("Nhap so nguyen x:");
            int n = Function.int_in("Nhap so nguyen n:");

            // Tao bien
            double S = 1;
            double factorial = 1;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                for (int a = 1; a <= (2*i); a++) // 2nd loop to get factorial value
                {
                    Console.WriteLine($"Factorial = {factorial}");
                    factorial *= a;
                }
                Console.WriteLine($"S = {S}");
                S += Math.Pow(x, (2 * i)) / factorial;
                factorial = 1; // Reset factorial value for next loop
            }
            Console.WriteLine($"Bai 018: Voi x = {x}, S({n}) = {S}.");
        }
    }
}

