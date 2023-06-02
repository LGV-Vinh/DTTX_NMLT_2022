using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_347 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 347(*): Đếm số lượng giá trị “Yên Ngựa” trên ma trận. Một phần tử được gọi là Yên Ngựa khi nó lớn nhất trên dòng và nhỏ nhất trên cột");

            int[,] a = Function.NhapMang2Chieu();
            Function.XuatMang2Chieu(a);
            int kq = Function.DemPhanTuYenNgua(a);
            Console.WriteLine(kq);
        }
    }
}
