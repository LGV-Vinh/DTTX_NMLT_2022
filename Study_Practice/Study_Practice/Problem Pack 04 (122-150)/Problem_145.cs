using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_145 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 145: Tìm số hoàn thiện đầu tiên trong mảng 1 chiều số nguyên. Nếu mảng không có số hoàn thiện thì trả về  -1");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int kq = Function.SoHoanThienDauTienMang(a);
            Console.WriteLine(kq);
        }
    }
}
