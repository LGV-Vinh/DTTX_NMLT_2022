using System;
using System.Collections.Generic;
using System.Linq;
namespace Study_Practice
{
    public class Problem_028 : Problem_000
    {
        public Problem_028()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 28: Cho số nguyên dương n. Tính tổng các ước số nhỏ hơn chính nó");

            // Tao input
            int n = Function.Int_In("Nhap so nguyen n:");

            // List uoc so nho hon so n
            List<int> uocSo = new List<int>();

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    uocSo.Add(i);
                }
            }

            Console.WriteLine($"Cac uoc so cua {n} (va < {n}) la:");
            foreach (int uoc in uocSo)
            {
                Console.Write(uoc + " ");
            }

            // Sum
            int tongUocSo = uocSo.Sum();
            Console.WriteLine();
            Console.WriteLine($"Bai 028: Tong ca uoc so cua {n} (va < {n}) la: {tongUocSo}");
        }
    }
}

