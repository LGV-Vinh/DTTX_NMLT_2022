using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_146 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 146: Tìm giá trị âm đầu tiên trong mảng 1 chiều các số thực. Nếu mảng không có giá trị âm thì trả về -1");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMangSoThuc(a);
        }
    }
}
