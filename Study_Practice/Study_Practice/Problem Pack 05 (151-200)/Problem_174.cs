using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_174 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 174 (*): Cho mảng số thực có nhiều hơn 2 giá trị và các giá trị trong mảng khác nhau từng đôi một. Hãy viết hàm liệt kê tất cả các cặp giá trị (a, b) trong mảng thỏa điều kiện a <= b");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMang(a);
            Console.WriteLine();
            Function.TimCapSo(a);
        }
    }
}
