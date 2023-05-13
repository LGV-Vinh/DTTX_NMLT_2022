using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_176 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 176: Hãy liệt kê các số âm trong mảng 1 chiều các số thực");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMang(a);
            Console.WriteLine();
            Function.LietKeSoAm(a);
        }
    }
}
