using System;
namespace Study_Practice
{
    public class Problem_048 : Problem_000
    {
        public Problem_048()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 48: Hãy tính tích các chữ số lẻ của số nguyên dương n");

            // Input
            int n_in = Function.Int_In("Nhap so nguyen duong n:");

            // Variable
            int digit = 0;
            int total = 1;
            int n = n_in;

            // Loop
            while (n != 0)
            {
                digit = n % 10;
                n /= 10;
                if (digit % 2 != 0)
                {
                    total *= digit;
                }
            }
            Console.WriteLine($"Tich cac chu so le cua so nguyen duong {n_in} = {total}.");
        }
    }
}

