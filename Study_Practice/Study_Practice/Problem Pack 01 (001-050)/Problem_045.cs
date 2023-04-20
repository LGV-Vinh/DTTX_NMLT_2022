using System;
namespace Study_Practice
{
    public class Problem_045 : Problem_000
    {
        public Problem_045()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 45: Hãy tính tích các chữ số của số nguyên dương n");

            // Input
            int n_in = Function.Int_In("Nhap so nguyen duong n:");

            // Variable
            int digit = 0;
            int n = n_in;
            int total = 1;

            // Loop
            while (n != 0)
            {
                digit = n % 10;
                total *= digit;
                n /= 10;
            }
            Console.WriteLine($"Tich cac chu so cua so nguyen duong {n_in} = {total}.");
        }
    }
}

