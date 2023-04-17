﻿using System;
namespace Study_Practice
{
    public class Problem_038 : Problem_000
    {
        public Problem_038()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 38: Tính S(n) = CanBac N + 1(N + CanBac N(N – 1 +…+CanBac3(2 + CanBac2(1)))) có n dấu căn");

            // Tao input
            int n = Function.int_in("Nhap so nguyen n:");

            // Tao bien
            double S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                double temp = S;
                S = Math.Pow(i + temp, (float)1 / (i + 1));
            }
            Console.WriteLine($"S({n}) = {S}.");
        }
    }
}

