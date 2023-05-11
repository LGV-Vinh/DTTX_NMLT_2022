using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_155 :  Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 155: Hãy tìm giá trị trong mảng các số thực xa giá trị x nhất");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMang(a);
            Console.WriteLine();
            double x = Function.Double_In("Nhap so x:");
            int chiSo = Function.ChiSoXaNhat(a, x);
            Console.WriteLine(a[chiSo]);
        }
    }
}
