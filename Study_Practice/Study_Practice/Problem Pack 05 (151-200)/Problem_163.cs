using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_163 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 163: Tìm số chính phương đầu tiên trong mảng 1 chiều các số nguyên");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int chiSo = Function.ChiSoChinhPhuongDauTienMang(a);
            int kq = (chiSo > -1) ? a[chiSo] : chiSo;
            Console.WriteLine(kq);
        }
    }
}
