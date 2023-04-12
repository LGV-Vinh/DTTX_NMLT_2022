﻿using System;
namespace Study_Practice
{
    public class Problem_009 : Problem_000
    {
        public Problem_009()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 9: Tính T(n) = 1 x 2 x 3…x N");

            // Tao input
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            int T = 1;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                T *= i;
            }
            Console.WriteLine($"Bai 009: T({n}) = {T}.");
        }
    }
}