using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_199 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 199: Hãy liệt kê các vị trí mà giá trị tại đó là số nguyên tố trong mảng 1 chiều các số nguyên");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            Console.WriteLine("Vi tri gia tri phu hop la:");
            Function.LietKeViTriSoNguyenTo(a);
        }
    }
}
