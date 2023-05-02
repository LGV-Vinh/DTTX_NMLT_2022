using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_123 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 123: Viết hàm tìm 1 vị trí mà giá trị tại vị trí đó là giá trị nhỏ nhất trong mảng 1 chiều các số nguyên");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            int kq = Function.ChiSoNguyenNhoNhat(a);
            Console.WriteLine($"Ket qua la {kq}");
        }
    }
}
