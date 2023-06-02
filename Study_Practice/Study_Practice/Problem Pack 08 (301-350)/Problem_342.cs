using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_342 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 342(*): Đếm số lượng phần tử cực đại trong ma trận các số thực. Một phần tử được gọi là cực đại khi nó lớn hơn các phần tử xung quanh");

            int[,] a = Function.NhapMang2Chieu();
            Function.XuatMang2Chieu(a);
            int kq = Function.DemPhanTuCucDai(a);
            Console.WriteLine(kq);
        }
    }
}
