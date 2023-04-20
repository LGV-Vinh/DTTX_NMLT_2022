using System;
using System.Collections.Generic;
namespace Study_Practice
{
    public class Problem_020 : Problem_000
    {
        public Problem_020()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 20: Liệt kê tất cả các “ước số” của số nguyên dương n");

            // Tao input
            int n = Function.Int_In("Nhap so nguyen n:");

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
            Console.WriteLine($"Bai 020: Cac uoc so cua {n} la:");
            foreach (int uoc in uocSo)
            {
                Console.Write(uoc + " ");
            }
        }
    }
}

