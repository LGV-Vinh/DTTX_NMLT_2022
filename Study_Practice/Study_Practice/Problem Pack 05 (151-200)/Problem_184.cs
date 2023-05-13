using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_184 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 184: Hãy liệt kê các vị trí mà giá trị tại đó là số nguyên tố trong mảng 1 chiều các số nguyên");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            Function.LietKeViTriSoNguyenTo(a);
        }
    }
}
