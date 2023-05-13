using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_286 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 286: Dịch trái xoay vòng k phần tử trong mảng");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int k = Function.Int_In("Nhap gia tri k:");
            Function.DichTraiXoayVong(a, k);
            Function.XuatMang(a);
        }
    }
}
