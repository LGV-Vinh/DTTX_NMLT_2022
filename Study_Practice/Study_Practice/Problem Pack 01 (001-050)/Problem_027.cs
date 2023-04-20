using System;
using System.Collections.Generic;
using System.Linq;
namespace Study_Practice
{
    public class Problem_027 : Problem_000
    {
        public Problem_027()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 27: Đếm số lượng “ước số chẵn” của số nguyên dương n");

            // Tao input
            int n = Function.Int_In("Nhap so nguyen n:");

            // List uoc so
            List<int> uocSo = Function.ListUocSo(n);

            // List uoc so chan
            List<int> uocSoChan = new List<int>();
            Console.WriteLine($"Cac uoc so chan cua {n} la:");
            foreach (int uoc in uocSo)
            {
                if (uoc % 2 == 0)
                {
                    Console.Write(uoc + " ");
                    uocSoChan.Add(uoc);
                }
            }

            // Dem uoc so chan
            int soLuong = uocSoChan.Count();
            Console.WriteLine();
            Console.Write($"Bai 027: So {n} co so luong uoc so la: {soLuong}");
        }
    }
}

