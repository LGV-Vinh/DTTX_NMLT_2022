using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_327 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 327: Tính tổng các giá trị nằm trên biên của ma trận");

            int[,] a = Function.NhapMang2Chieu();
            Function.XuatMang2Chieu(a);
            int kq = Function.TinhTongPhanTuBien(a);
            Console.WriteLine(kq);
        }
    }
}
