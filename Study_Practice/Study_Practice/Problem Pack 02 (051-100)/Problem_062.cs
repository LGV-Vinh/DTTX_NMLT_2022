using System;
namespace Study_Practice
{
    public class Problem_062 : Problem_000
    {
        public Problem_062()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 62: Cho 2 số nguyên dương a và b. Hãy tìm ước chung lớn nhất của 2 số này.");

            // Input
            int a = Function.Int_In("Nhap so nguyen duong a:");
            int b = Function.Int_In("Nhap so nguyen duong b:");

            int result = Function.UocSoChungLonNhat(a, b);
            Console.WriteLine($"Uoc so chung lon nhat cua {a} va {b} la {result}.");
        }
    }
}

