using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_317 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 317: Viết hàm đếm số lượng số nguyên tố trong ma trận số nguyên");

            int[,] a = Function.NhapMang2Chieu();
            Function.XuatMang2Chieu(a);
            int kq = Function.DemSoNguyenToMang2Chieu(a);
            Console.WriteLine($"Co {kq} so nguyen to.");
        }
    }
}
