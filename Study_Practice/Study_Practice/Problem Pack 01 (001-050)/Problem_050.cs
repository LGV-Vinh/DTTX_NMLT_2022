using System;
namespace Study_Practice
{
    public class Problem_050 : Problem_000
    {
        public Problem_050()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 50: Hãy tìm số đảo ngược của số nguyên dương n");

            // Input
            int n_in = Function.Int_In("Nhap so nguyen duong n:");

            // Variable
            int reversed = 0;
            int digit = 0;
            int n = n_in;

            // Loop
            while (n != 0)
            {
                digit = n % 10;
                reversed = reversed * 10 + digit;
                n /= 10;
            }
            Console.WriteLine($"So dao nguoc cua so nguyen duong {n_in} la {reversed}.");
        }
    }
}

