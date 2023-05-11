using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_166 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 166: Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm giá trị đầu tiên trong mảng có dạng 2^k. Nếu mảng không có giá trị dạng 2k thì hàm sẽ trả về 0");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int chiSo = Function.ChiSoDauTienCoDang2MuK(a);
            int kq = (chiSo > -1) ? a[chiSo] : 0;
            Console.WriteLine(kq);
        }
    }
}
