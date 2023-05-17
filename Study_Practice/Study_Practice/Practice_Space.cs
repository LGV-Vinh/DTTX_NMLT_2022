using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Practice_Space : Problem_000
    {
        public override void Solution()
        {
            // Nhap mang 2 chieu
            int[,] a = Function.NhapMang2Chieu();

            // Xuat mang 2 chieu
            Function.XuatMang2Chieu(a);

            // Tinh tong mang 2 chieu
            int sum = Function.TongMang2Chieu(a);
            Console.WriteLine(sum);
        }
    }
}
