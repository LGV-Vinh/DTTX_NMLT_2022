using System;
using System.Collections.Generic;
namespace Study_Practice
{
    public class Problem_024 : Problem_000
    {
        public Problem_024()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 24: Liệt kê tất cả các “ước số lẻ” của số nguyên dương n");

            // Tao input
            int n = Function.Int_In("Nhap so nguyen n:");

            // Tao list uoc so
            List<int> uocSo = Function.ListUocSo(n);

            // Output list uoc so
            Console.WriteLine($"Cac uoc so cua {n} la:");
            foreach (int uoc in uocSo)
            {
                Console.Write(uoc + " ");
            }

            // Tim uoc so le
            Console.WriteLine();
            Console.WriteLine($"Bai 024: Cac uoc so le cua {n} la:");
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

