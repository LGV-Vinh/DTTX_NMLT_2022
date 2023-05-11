using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_158 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 158: Cho mảng 1 chiều các số thực, hãy tìm giá trị x sao cho đoạn [-x, x] chứa tất cả các giá trị trong mảng");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMang(a);
            Console.WriteLine();
            double x1 = Math.Abs(a[Function.ChiSoNhoNhatMang(a)]);
            double x2 = Math.Abs(a[Function.ChiSoLonNhatMang(a)]);
            double x = Math.Max(x1, x2);
            Console.WriteLine($"Doan chua tat ca cac gia tri trong mang la [{-x}, {x}], vay x = {x}");
        }
    }
}
