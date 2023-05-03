using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_142 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 142: Tìm giá trị nhỏ nhất trong mảng 1 chiều số thực");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMangSoThuc(a);
            Console.WriteLine();
            int kq = Function.ChiSoThucNhoNhat(a);
            Console.WriteLine(a[kq]);
        }
    }
}
