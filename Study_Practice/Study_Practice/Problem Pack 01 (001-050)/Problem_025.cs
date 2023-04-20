using System;
using System.Collections.Generic;
using System.Linq;
namespace Study_Practice
{
    public class Problem_025 : Problem_000
    {
        public Problem_025()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 25: Tính tổng tất cả các “ước số chẵn” của số nguyên dương n");

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

            // Tao list uoc so chan
            List<int> uocSoChan = new List<int>();

            Console.WriteLine();
            Console.WriteLine($"Cac uoc so le cua {n} la:");
            foreach (int uoc in uocSo)
            {
                if (uoc % 2 == 0)
                {
                    Console.Write(uoc + " ");
                    uocSoChan.Add(uoc);
                }
            }

            int tongUocSoChan = uocSoChan.Sum();
            Console.WriteLine();
            Console.WriteLine($"Bai 025: Tong cac uoc so chan cua {n} la: {tongUocSoChan}.");

        }
    }
}

