using System;
namespace Study_Practice
{
    public class Problem_010 : Problem_000
    {
        public Problem_010()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 10: Tính T(x, n) = x^n");

            // Tao input
            int x = Function.int_in("Nhap so nguyen x:");
            int n = Function.int_in("Nhap so nguyen n:");

            // Giai
            double T = Math.Pow(x, n);

            Console.WriteLine($"Bai 010: T({x}, {n}) = {T}.");
        }
    }
}