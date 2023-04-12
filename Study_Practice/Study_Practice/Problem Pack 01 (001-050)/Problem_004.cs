﻿using System;
namespace Study_Practice
{
    public class Problem_004 : Problem_000
    {
        public Problem_004()
        {
        }
        public override void Solution()
        {
            // Bài 4: Tính S(n) = ½ + ¼ + … + 1/2n
            // Tao input
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            double S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                double step = 1 / (double)(2 * i);
                S += step;
            }
            Console.WriteLine($"Bai 004: S({n}) = {S}.");
        }
    }
}

