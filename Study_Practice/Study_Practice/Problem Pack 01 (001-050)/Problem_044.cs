using System;
namespace Study_Practice
{
    public class Problem_044 : Problem_000
    {
        public Problem_044()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 44: Hãy tính tổng các chữ số của số nguyên dương n");

            // Input
            int n_in = Function.int_in("Nhap so nguyen duong n:");

            // Variable
            int digit = 0;
            int sum = 0;
            int n = n_in;

            // Loop
            while (n != 0)
            {
                digit = n % 10;
                sum += digit;
                n /= 10;
            }
            Console.WriteLine($"Tong cac chu so cua so nguyen duong {n_in} = {sum}.");
        }
    }
}

