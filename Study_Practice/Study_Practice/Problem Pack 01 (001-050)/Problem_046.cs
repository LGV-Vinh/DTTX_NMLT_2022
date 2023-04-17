using System;
namespace Study_Practice
{
    public class Problem_046 : Problem_000
    {
        public Problem_046()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 46: Hãy đếm số lượng chữ số lẻ của số nguyên dương n");

            // Input
            int n_in = Function.int_in("Nhap so nguyen duong n:");

            // Variable
            int digit = 0;
            int count = 0;
            int n = n_in;

            // Loop
            while (n != 0)
            {
                digit = n % 10;
                n /= 10;
                if (digit % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"So luong chu so le cua so nguyen duong {n_in} = {count}.");
        }
    }
}

