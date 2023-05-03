using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_130 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 129 + 131: Viết hàm nhập, xuất mảng 1 chiều các số nguyên");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
        }
    }
}
