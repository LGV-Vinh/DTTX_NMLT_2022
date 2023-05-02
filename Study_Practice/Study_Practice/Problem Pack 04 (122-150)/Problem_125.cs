using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_125 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 125: Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            int kq = Function.DemSoNguyenToNhoHon100(a);
            Console.WriteLine();
            Console.WriteLine(kq);
        }
    }
}
