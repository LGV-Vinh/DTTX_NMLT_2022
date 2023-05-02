using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_127 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 127: Viết hàm sắp xếp mảng 1 chiều các số thực tăng dần");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMangSoThuc(a);
            Function.SapXepMangSoThuc(a);
            Console.WriteLine();
            Function.XuatMangSoThuc(a);
        }
    }
}
