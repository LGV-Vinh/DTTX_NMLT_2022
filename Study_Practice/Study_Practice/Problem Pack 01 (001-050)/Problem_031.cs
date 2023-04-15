using System;
namespace Study_Practice
{
    public class Problem_031 : Problem_000
    {
        public Problem_031()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 31: Cho số nguyên dương n. Kiểm tra xem n có phải là số nguyên tố hay không");

            // Tao input
            Console.WriteLine("Nhap so nguyen duong n:");
            int n = int.Parse(Console.ReadLine());

            // Kiem tra so nguyen to
            if (n <= 1)
            {
                Console.WriteLine($"Bai 031: {n} khong phai la so nguyen to.");
                return;
            }

            // List uoc so
            List<int> uocSo = Function.listUocSo(n);

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"Cac uoc so cua {n} la:");
                    foreach (int uoc in uocSo)
                    {
                        Console.Write(uoc + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Bai 031: {n} khong phai la so nguyen to.");
                    return;
                }
            }
            Console.WriteLine($"Cac uoc so cua {n} la:");
            foreach (int uoc in uocSo)
            {
                Console.Write(uoc + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Bai 031: {n} la so nguyen to.");
        }
    }
}

