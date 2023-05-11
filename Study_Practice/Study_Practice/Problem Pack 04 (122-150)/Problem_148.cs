using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_148 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 148: Tìm số nguyên tố cuối cùng trong mảng 1 chiều các số nguyên. Nếu mảng không có số nguyên tố thì trả về  -1");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int chiSo = Function.SoNguyenToCuoiCung(a);
            int kq;
            kq = (chiSo > -1) ? a[chiSo] : chiSo;
            Console.WriteLine(kq);
        }
    }
}
