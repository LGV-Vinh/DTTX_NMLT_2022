using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_200 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 200: Tính tổng các phần tử trong mảng");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int kq = Function.TongGiaTriTrongMang(a);
            Console.WriteLine(kq);
        }
    }
}
