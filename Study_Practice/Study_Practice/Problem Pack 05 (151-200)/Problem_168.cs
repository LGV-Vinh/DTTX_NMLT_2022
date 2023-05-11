using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_168 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 168: Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm giá trị lớn nhất trong mảng có dạng 5^k. Nếu mảng khong tồn tại giá trị 5^k thì hàm sẽ trả về 0");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int chiSo = Function.ChiSoLonNhatCoDangNMuK(a, 5);
            int kq = (chiSo > -1) ? a[chiSo] : 0;
            Console.WriteLine(kq);
        }
    }
}
