using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_183 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 183: Hãy liệt kê các vị trí mà giá trị tại đó là giá trị lớn nhất trong mảng 1 chiều các số thực");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMang(a);
            Console.WriteLine();
            Function.LietKeViTriGiaTriLonNhat(a);
        }
    }
}
