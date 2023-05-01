using System;
namespace Study_Practice
{
    public class Problem_077 : Problem_000
    {
        public Problem_077()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 77: Viết chương trình tính tổng của dãy số sau: S(n) = 1 + 2 + 3 + … + n");

            // Input
            int n = Function.Int_In("Nhap so nguyen n:");

            int S = 0;

            for (int i = 1; i <= n; i++)
            {
                S += i;
            }
            Console.WriteLine($"S({n}) = {S}.");
        }
    }
}

