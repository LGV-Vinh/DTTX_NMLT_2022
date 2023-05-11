using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_157 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 157: Cho mảng 1 chiều các số thực, hãy tìm đoạn [a, b] sao cho đoạn này chứa tất cả các giá trị trong mảng");

            double[] arr = Function.NhapMangSoThuc();
            Function.XuatMang(arr);
            Console.WriteLine();
            double a = arr[Function.ChiSoNhoNhatMang(arr)];
            double b = arr[Function.ChiSoLonNhatMang(arr)];
            Console.WriteLine($"Doan chua tat ca cac gia tri trong mang la [{a}, {b}]");
        }
    }
}
