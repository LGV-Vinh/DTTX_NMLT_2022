using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_143 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 143: Viết hàm tìm số chẵn đầu tiên trong mảng các số nguyên. Nếu mảng không có giá trị chẵn thì trả về  -1");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int kq = Function.SoChanDauTienMang(a);
            Console.WriteLine(kq);
        }
    }
}
