using System;
using System.Collections.Generic;
using System.Linq;
namespace Study_Practice
{
    public class Problem_021 : Problem_000
    {
        public Problem_021()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 21: Tính tổng tất cả các “ ước số” của số nguyên dương n");

            // Tao input
            int n = Function.int_in("Nhap so nguyen n:");

            // Tao list
            List<int> uocSo = new List<int>();

            // Loop tim uoc so va add vao list
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    uocSo.Add(i);
                }
            }
            Console.WriteLine($"Cac uoc so cua {n} la:");
            foreach (int uoc in uocSo)
            {
                Console.Write(uoc + " ");
            }
            Console.WriteLine();
            int tongUocSo = uocSo.Sum();
            Console.WriteLine($"Bai 021: Tong gia tri cac cuoc so cua {n} la: {tongUocSo}.");
        }
    }
}

