using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_391 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 391(*): Tìm ma trận con có tổng lớn nhất");

            int[,] a = Function.NhapMang2Chieu();
            Function.XuatMang2Chieu(a);
            int xMax, yMax, rMax, cMax;
            Function.MaTranConCoTongLonNhat(a, out xMax, out yMax, out rMax, out cMax);
            Console.WriteLine($"{xMax}, {yMax}, {rMax}, {cMax}");
        }
    }
}
