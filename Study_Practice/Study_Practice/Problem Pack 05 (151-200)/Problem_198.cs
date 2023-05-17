using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_198 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 198: Hãy liệt kê các vị trí mà giá trị tại đó là giá trị lớn nhất trong mảng 1 chiều các số thực");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMang(a);
            Console.WriteLine();
            Console.WriteLine("Vi tri gia tri phu hop la:");
            Function.LietKeViTriGiaTriLonNhat(a);
        }
    }
}
