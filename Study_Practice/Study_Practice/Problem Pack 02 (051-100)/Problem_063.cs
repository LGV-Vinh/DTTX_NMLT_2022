using System;
namespace Study_Practice
{
    public class Problem_063 : Problem_000
    {
        public Problem_063()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 63: Cho 2 số nguyên dương a và b. Hãy tìm bội chung nhỏ nhất của 2 số này");

            // Input
            int a = Function.Int_In("Nhap so nguyen duong a:");
            int b = Function.Int_In("Nhap so nguyen duong b:");

            int result = Function.BoiSoChungNhoNhat(a, b);
            Console.WriteLine($"Boi so chung nho nhat cua {a} va {b} la {result}.");
        }
    }
}

