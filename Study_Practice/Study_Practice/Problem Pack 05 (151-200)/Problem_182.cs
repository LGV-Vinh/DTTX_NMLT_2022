using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_182 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 182: Cho mảng 1 chiều các số thực. Hãy viết hàm liệt kê tất cả các giá trị trong mảng có ít nhất 1 lận cận trái dấu với nó");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMang(a);
            Console.WriteLine();
            Console.WriteLine("Cac so phu hop la:");
            Function.LietKeGiaTriTraiDau(a);
        }
    }
}
