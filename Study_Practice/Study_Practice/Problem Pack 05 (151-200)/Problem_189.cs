using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_189 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 189: Hãy liệt kê các giá trị trong mảng 1 chiều các số nguyên có chữ số đầu tiên là chữ số lẻ");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            Function.Bai189(a);
        }
    }
}
