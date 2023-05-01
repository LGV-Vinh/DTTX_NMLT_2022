using System;
namespace Study_Practice
{
    public class Problem_076 : Problem_000
    {
        public Problem_076()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 76: Kiểm tra số nguyên 4 byte có dạng 3^k hay không");

            // Input
            int n = Function.Int_In("Nhap so nguyen:");

            int i;
            int p = 1;

            for (i = 1; p < n; i++)
            {
                p *= 3;
            }
            if (p == n)
            {
                Console.WriteLine($"{n} co dang 3^{i-1}.");
            }
            else
            {
                Console.WriteLine($"{n} khong co dang 3^k.");
            }
        }
    }
}

