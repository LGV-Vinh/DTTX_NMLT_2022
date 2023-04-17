using System;
using System.Collections.Generic;
using System.Linq;
namespace Study_Practice
{
    public class Problem_030 : Problem_000
    {
        public Problem_030()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 30: Cho số nguyên dương n. Kiểm tra xem n có phải là số hoàn thiện hay không");

            // Tao input
            int n = Function.int_in("Nhap so nguyen n:");

            // List uoc so
            List<int> uocSo = Function.listUocSo(n);

            // Kiem tra so hoan thien
            int sum = uocSo.Sum() - n;

            if (sum == n)
            {
                Console.Write(1);
                foreach (int uoc in uocSo) if (uoc < n && uoc > 1)
                    {
                        Console.Write(" + " + uoc);
                    }
                Console.WriteLine($" = {sum}");
                Console.WriteLine($"Bai 030: Tong cac uoc nguyen duong thuc su cua {n} = {sum}. Vay {n} la so hoan thien.");
            }
            else
            {
                Console.Write(1);
                foreach (int uoc in uocSo) if (uoc < n && uoc > 1)
                    {
                        Console.Write(" + " + uoc);
                    }
                Console.WriteLine($" = {sum}");
                Console.WriteLine($"Bai 030: Tong cac uoc nguyen duong thuc su cua {n} != {sum}. Vay {n} khong phai la so hoan thien.");
            }
        }
    }
}

