using System;
namespace Study_Practice
{
    public class Problem_059 : Problem_000
    {
        public Problem_059()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 59: Hãy kiểm tra số nguyên dương n có phải là số đối xứng hay không");

            // Input
            int n_in = Function.Int_In("Nhap so nguyen duong n");

            // Variable
            int digit = 0;
            int n = n_in;
            int reversed = 0;

            // Invalid case
            if (n_in < 10)
            {
                Console.WriteLine($"So nguyen duong {n_in} KHONG phai la so doi xung.");
                return;
            }

            // Get reversed interger
            while (n != 0)
            {
                digit = n % 10;
                reversed = reversed * 10 + digit;
                n /= 10;
            }

            if (reversed == n_in)
            {
                Console.WriteLine($"So nguyen duong {n_in} la so doi xung.");
            }
            else
            {
                Console.WriteLine($"So nguyen duong {n_in} KHONG phai la so doi xung.");
            }
        }
    }
}

