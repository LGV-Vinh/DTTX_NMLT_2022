using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_170 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 170: Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm số nguyên tố nhỏ nhất lớn hơn mọi giá trị có trong mảng");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int kq = Function.SoNguyenToNhoNhatLonHonMoiGiaTriMang(a);
            Console.WriteLine(kq);
        }
    }
}
