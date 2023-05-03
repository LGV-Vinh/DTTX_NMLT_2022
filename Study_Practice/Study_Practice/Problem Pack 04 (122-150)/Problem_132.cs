using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_132 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 132: Viết hàm liệt kê các giá trị chẵn trong mảng 1 chiều các số nguyên");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            Function.LietKeGiaTriChanTrongMang(a);
        }
    }
}
