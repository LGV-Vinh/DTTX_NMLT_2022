using System;
using System.Collections.Generic;
using System.Linq;
namespace Study_Practice
{
    public class Problem_029 : Problem_000
    {
        public Problem_029()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 29: Tìm ước số lẻ lớn nhất của số nguyên dương n. Ví dụ n = 100 ước lẻ lớn nhất là 25");

            // Tao input
            int n = Function.int_in("Nhap so nguyen n:");

            // List uoc so
            List<int> uocSo = Function.listUocSo(n);

            // List uoc so le
            List<int> uocSoLe = new List<int>();
            Console.WriteLine($"Cac uoc so le cua {n} la:");
            foreach (int uoc in uocSo)
            {
                if (uoc % 2 != 0)
                {
                Console.Write(uoc + " ");
                uocSoLe.Add(uoc);
                }
            }
            int max = uocSoLe.Max();
            Console.WriteLine();
            Console.WriteLine($"Bai 029: Uoc so le lon nhat cua {n} la: {max}");
        }
    }
}

