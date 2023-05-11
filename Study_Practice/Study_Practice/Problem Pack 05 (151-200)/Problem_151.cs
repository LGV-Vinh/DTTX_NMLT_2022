using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_151 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 151: Hãy tìm số nguyên tố lớn nhất trong mảng 1 chiều các số nguyên. Nếu mảng không có số nguyên tố thì trả về -1");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int chiSo = Function.ChiSoNguyenToLonNhat(a);
            int kq = (chiSo > -1) ? a[chiSo] : chiSo;
            Console.WriteLine(kq);
        }
    }
}
