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
            Console.WriteLine("Nhap so nguyen x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Giai
            double T = Math.Pow(x, n);

            Console.WriteLine($"Bai 010: T({x}, {n}) = {T}.");
        }
    }
}