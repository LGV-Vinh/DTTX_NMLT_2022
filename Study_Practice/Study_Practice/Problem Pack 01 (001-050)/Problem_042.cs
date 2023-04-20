using System;
namespace Study_Practice
{
    public class Problem_042 : Problem_000
    {
        public Problem_042()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 42: Cho n là số nguyên dương. Hãy tìm giá trị nguyên dương k lớn nhất sao cho S(k)  < n. Trong đó chuỗi k được định nghĩa như sau: S(k) = 1 + 2 + 3 + … + k");

            // Input
            int n = Function.Int_In("Nhap so nguyen duong n:");

            // Variable
            int S = 0;
            int k = 1;

            // Loop
            while (S + k < n)
            {
                S += k;
                k++;
            }
            Console.WriteLine($"Voi n = {n}, S({k-1}) = {S}.");
        }
    }
}

