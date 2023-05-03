using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_128 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 128 + 130: Viết hàm nhập, xuất mảng 1 chiều các số thực");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMangSoThuc(a);
        }
    }
}
