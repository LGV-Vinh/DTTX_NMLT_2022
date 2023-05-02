using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_126 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 126: Viết hàm tính tổng các giá trị âm trong mảng 1 chiều các số thực");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMangSoThuc(a);
            double sum = Function.TongGiaTriAmTrongMangSoThuc(a);
            Console.WriteLine();
            Console.WriteLine($"Tong cac so am trong mang la {sum}");
        }
    }
}
