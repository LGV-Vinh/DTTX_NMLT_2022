﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace Study_Practice
{
    public class Problem_023 : Problem_000
    {
        public Problem_023()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 23: Đếm số lượng “ước số” của số nguyên dương n");

            // Tao input
            Console.WriteLine("Nhap so nguyen n:");
            int n = int.Parse(Console.ReadLine());

            // Tim list uoc so
            List<int> uocSo = Function.listUocSo(n);

            // Output
            Console.WriteLine($"Cac uoc so cua {n} la:");
            foreach (int uoc in uocSo)
            {
                Console.Write(uoc + " ");
            }

            int soLuong = uocSo.Count();
            Console.WriteLine();
            Console.WriteLine($"Bai 023: So luong uoc so cua {n} la: {soLuong}.");
        }
    }
}
