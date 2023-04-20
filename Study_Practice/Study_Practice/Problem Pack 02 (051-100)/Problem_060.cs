using System;
namespace Study_Practice
{
    public class Problem_060 : Problem_000
    {
        public Problem_060()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 60: Hãy kiểm tra các chữ số của số nguyên dương n có tăng dần từ trái sang phải hay không");

            // Input
            int n_in = Function.Int_In("Nhap so nguyen duong n:");

            // Variable
            int currentDigit = 0;
            int n = n_in;
            int previousDigit = int.MaxValue;
            bool isIncreasing = true;

            // Loop and chcek each digit
            while (n > 0)
            {
                currentDigit = n % 10;
                if (currentDigit >= previousDigit)
                {
                    isIncreasing = false;
                    break;
                }
                previousDigit = currentDigit;
                n /= 10;
            }

            if (isIncreasing)
            {
                Console.WriteLine($"Cac chu so cua so nguyen duong {n_in} tang dan tu trai sang phai.");
            }
            else
            {
                Console.WriteLine($"Cac chu so cua so nguyen duong {n_in} KHONG tang dan tu trai sang phai.");
            }
        }
    }
}

