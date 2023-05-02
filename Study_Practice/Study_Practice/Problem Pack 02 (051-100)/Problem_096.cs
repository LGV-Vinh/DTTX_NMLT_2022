using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_096 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 96: Viết chương trình nhập giá trị x sau tính giá trị của hàm số");
            Console.WriteLine("f(x) = 2x^2 + 5x + 9 khi x >= 5, f(x) = -2x^2 + 4x – 9 khi x < 5");

            int x = Function.Int_In("Nhap so x:");
            double kq;

            if (x >= 5)
            {
                kq = 2 * Math.Pow(x, 2) + 5 * x + 9;
            }
            else
            {
                kq = -2 * Math.Pow(x, 2) + 4 * x - 9;
            }
            Console.WriteLine($"f({x}) = {kq}.");
        }
    }
}
