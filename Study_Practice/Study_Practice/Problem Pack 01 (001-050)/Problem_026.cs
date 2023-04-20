using System;
using System.Collections.Generic;
using System.Linq;
namespace Study_Practice
{
    public class Problem_026 : Problem_000
    {
        public Problem_026()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 26: Tính tích tất cả các “ước số lẻ” của số nguyên dương n");

            // Tao input
            int n = Function.Int_In("Nhap so nguyen n:");

            // List uoc so
            List<int> uocSo = Function.ListUocSo(n);

            // List uoc so le
            Console.WriteLine($"Bai 026: Cac uoc so le cua {n} la:");
            foreach (int uoc in uocSo)
            {
                if (uoc % 2 != 0)
                {
                    Console.Write(uoc + " ");
                }
            }
        }
    }
}

