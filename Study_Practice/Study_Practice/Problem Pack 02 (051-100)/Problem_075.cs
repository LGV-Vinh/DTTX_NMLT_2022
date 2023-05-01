using System;
namespace Study_Practice
{
    public class Problem_075 : Problem_000
    {
        public Problem_075()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 75: Kiểm tra số nguyên 4 byte có dạng 2^k hay không");

            // Input
            int n = Function.Int_In("Nhap so nguyen:");

            int i;
            int p = 1;

            for (i = 1; p < n; i++)
            {
                p *= 2;
            }
            if (p == n)
            {
                Console.WriteLine($"{n} co dang 2^{i-1}.");
            }
            else
            {
                Console.WriteLine($"{n} khong co dang 2^k.");
            }
        }
    }
}

