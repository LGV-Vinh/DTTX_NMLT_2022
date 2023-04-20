using System;
namespace Study_Practice
{
    public class Problem_032 : Problem_000
    {
        public Problem_032()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 32: Cho số nguyên dương n. Kiểm tra xem n có phải là số chính phương hay không");

            // Tao input
            int n = Function.Int_In("Nhap so nguyen n:");

            // Tim so sqrt
            double sqrt = Math.Sqrt(n);

            // Kiem tra so chinh phuong
            if (sqrt == Math.Round(sqrt))
            {
                Console.WriteLine($"Bai 032: Can bac 2 cua {n} = {sqrt}, vay {n} la so chinh phuong.");
                return;
            }
            Console.WriteLine($"Bai 032: Can bac 2 cua {n} = {sqrt}, vay {n} khong phai la so chinh phuong.");
        }
    }
}

