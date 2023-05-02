using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_092 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 92: Tìm ước số chung lớn nhất của 2 số nguyên dương");

            int a = Function.Int_In("Nhap so nguyen duong a:");
            int b = Function.Int_In("Nhap so nguyen duong b:");

            int USLN = Function.USLN(a, b);

            Console.WriteLine($"Uoc so lon nhat cua {a} va {b} la {USLN}.");
        }
    }
}
