﻿using System;
namespace Study_Practice
{
    public class Problem_007 : Problem_000
    {
        public Problem_007()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 7: Tính S(n) = ½ + 2/3 + ¾ + …. + n / n + 1");

            // Tao input
            int n = Function.Int_In("Nhap so nguyen n:");

            // Tao bien
            double S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                double step = (double)i / (i + 1);
                S += step;
            }
            Console.WriteLine($"Bai 007: S({n}) = {S}.");
        }
    }
}