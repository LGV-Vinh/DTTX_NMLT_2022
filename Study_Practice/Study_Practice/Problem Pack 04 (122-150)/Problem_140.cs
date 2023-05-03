using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_140 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 140: Hãy tìm giá trị dương nhỏ nhất trong mảng 1 chiều các số thực. Nếu mảng không có giá trị dương thì sẽ trả về -1");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMangSoThuc(a);
            Console.WriteLine();
            double kq = Function.GiaTriDuongNhoNhatMangSoThuc(a);
            Console.WriteLine(kq);
        }
    }
}
