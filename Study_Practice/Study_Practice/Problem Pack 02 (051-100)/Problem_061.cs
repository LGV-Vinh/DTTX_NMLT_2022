using System;
namespace Study_Practice
{
    public class Problem_061 : Problem_000
    {
        public Problem_061()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 61: Hãy kiểm tra các chữ số của số nguyên dương n có giảm dần từ trái sang phải hay không");

            // Input
            int n_in = Function.Int_In("Nhap so nguyen duong n:");

            // Variable
            int currentDigit = 0;
            int previousDigit = int.MinValue;
            int n = n_in;
            bool isDescreasing = true;

            // Loop and check each digit
            while (n > 0)
            {
                currentDigit = n % 10;
                if (currentDigit <= previousDigit)
                {
                    isDescreasing = false;
                    break;
                }
                previousDigit = currentDigit;
                n /= 10;
            }

            if (isDescreasing)
            {
                Console.WriteLine($"Cac chu so cua so nguyen duong {n_in} giam dan tu trai sang phai.");
            }
            else
            {
                Console.WriteLine($"Cac chu so cua so nguyen duong {n_in} KHONG giam dan tu trai sang phai.");
            }
        }
    }
}

