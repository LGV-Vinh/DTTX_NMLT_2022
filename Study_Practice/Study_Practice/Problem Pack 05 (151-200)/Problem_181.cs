using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_181 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 181: Cho mảng 1 chiều các số nguyên. Hãy viết hàm liệt kê các giá trị chẵn có ít nhất 1 lân cận cũng là giá trị chẵn");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            Console.WriteLine("Cac so phu hop la:");
            Function.Bai181(a);
        }
    }
}
