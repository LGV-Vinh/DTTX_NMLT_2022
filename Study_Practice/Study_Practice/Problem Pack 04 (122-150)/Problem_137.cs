using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_137 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 137: Tìm 1 vị trí mà giá trị tại vị trí đó là giá trị nhỏ nhất trong mảng 1 chiều các số thực");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMangSoThuc(a);
            Console.WriteLine();
            int kq = Function.ChiSoGiaTriNhoNhatMangSoThuc(a);
            Console.WriteLine(kq);
        }
    }
}
