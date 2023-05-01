using System;
namespace Study_Practice
{
    public class Problem_079 : Problem_000
    {
        public Problem_079()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 79: Hãy đếm số lượng chữ số của số nguyên dương n");

            int n = Function.Int_In("Nhap so nguyen duong n:");

            int count = 0;
            int n_in = n;

            if (n == 0)
            {
                Console.WriteLine($"So nguyen duong {n_in} co 1 chu so.");
                return;
            }

            while (n != 0)
            {
                count++;
                n /= 10;
            }
            Console.WriteLine($"So nguyen duong {n_in} co {count} chu so.");
        }
    }
}

