using System;
namespace Study_Practice
{
    public class Problem_049 : Problem_000
    {
        public Problem_049()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 49: Cho số nguyên dương n. Hãy tìm chữ số đầu tiên của n");

            // Input
            int n_in = Function.int_in("Nhap so nguyen duong n:");

            // Variable
            int n = n_in;

            // Loop
            while (n >= 10)
            {
                n /= 10;
            }
            Console.WriteLine($"Chu so dau tien cua so nguyen duong {n_in} = {n}.");
        }
    }
}

