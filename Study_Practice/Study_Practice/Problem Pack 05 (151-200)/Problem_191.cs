using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_191 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 191: Hãy liệt kê các giá trị cực đại trong mảng 1 chiều các số thực. Một phần tử được gọi là cực đại khi lớn hơn các phần tử lân cận");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMang(a);
            Console.WriteLine();
            Function.LietKeSoCucDai(a);
        }
    }
}
