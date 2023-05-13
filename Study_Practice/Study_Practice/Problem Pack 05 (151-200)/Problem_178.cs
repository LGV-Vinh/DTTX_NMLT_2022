using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_178 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 178: Hãy liệt kê các số chẵn trong mảng 1 chiều các số nguyên thuộc đoạn [x, y] cho trước (x, y là các số nguyên)");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int x = Function.Int_In("Nhap gia tri x:");
            int y = Function.Int_In("Nhap gia tri y:");
            Console.WriteLine($"Gia chi chan nam trong doan [{x}, {y}] la:");
            Function.LietKeGiaTriChanTrongDoanXY(a, x, y);
        }
    }
}
