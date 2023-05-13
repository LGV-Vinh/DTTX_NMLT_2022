using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_177 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 177: Hãy liệt kê các số trong mảng 1 chiều các số thực thuộc đoạn [x, y] cho trước");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMang(a);
            Console.WriteLine();
            double x = Function.Double_In("Nhap gia tri x:");
            double y = Function.Double_In("NHap gia tri y:");
            Console.WriteLine($"Cac gia tri nam trong doan ({x}, {y}):");
            Function.LietKeGiaTriTrongDoanXY(a, x, y);
        }
    }
}
