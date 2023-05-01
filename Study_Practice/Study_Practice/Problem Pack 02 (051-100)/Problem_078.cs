using System;
namespace Study_Practice
{
    public class Problem_078 : Problem_000
    {
        public Problem_078()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 78: Liệt kê tất cả các ước số của số nguyên dương n");

            int n = Function.Int_In("Nhap so nguyen duong n:");

            List<int> uocSo = Function.ListUocSo(n);

            Console.WriteLine($"So nguyen duong {n} co cac uoc so sau:");
            foreach (int uoc in uocSo)
            {
                Console.Write(uoc + " ");
            }
        }
    }
}

