using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_141 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 141: Hãy tìm vị trí giá trị dương nhỏ nhất trong mảng 1 chiều các số thực. Nếu mảng không có giá trị dương thì trả về  -1");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMangSoThuc(a);
            Console.WriteLine();
            int kq = Function.ChiSoDuongNhoNhatMangSoThuc(a);
            Console.WriteLine(kq);
        }
    }
}
