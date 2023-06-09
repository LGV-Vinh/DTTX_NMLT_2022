﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace Study_Practice
{
    public class Problem_022 : Problem_000
    {
        public Problem_022()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 22: Tính tích tất cả các “ước số” của số nguyên dương n");

            // Tao input
            int n = Function.Int_In("Nhap so nguyen n:");

            // Tim list uoc so
            List<int> uocSo = Function.ListUocSo(n);

            // Output
            Console.WriteLine($"Cac uoc so cua {n} la:");
            foreach (int uoc in uocSo)
            {
                Console.Write(uoc + " ");
            }

            int tichUocSo = uocSo.Aggregate((x, y) => x * y);
            Console.WriteLine();
            Console.WriteLine($"Bai 022: Tich cac uoc so cua {n} la: {tichUocSo}.");
        }
    }
}

