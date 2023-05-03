using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_133 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 133: Viết hàm liệt kê các vị trí mà giá trị tại đó là giá trị âm trong mảng 1 chiều các số thực");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMangSoThuc(a);
            Console.WriteLine();
            Function.LietKeChiSoAmTrongMangSoThuc(a);
        }
    }
}
