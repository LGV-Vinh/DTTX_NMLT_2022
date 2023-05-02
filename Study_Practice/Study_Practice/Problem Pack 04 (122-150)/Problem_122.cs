using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_122 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 122: Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMangSoThuc(a);
            int n = Function.ChiSoThucLonNhat(a);
            Console.WriteLine();
            Console.WriteLine(a[n]);
        }
    }
}
