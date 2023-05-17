using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_193 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 193: Cho mảng 1 chiều các số nguyên. Hãy viết hàm liệt kê các giá trị trong mảng có dạng 3^k. Nếu mảng không có giá trị đó thì trả về 0");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            Function.Bai193(a);
        }
    }
}
