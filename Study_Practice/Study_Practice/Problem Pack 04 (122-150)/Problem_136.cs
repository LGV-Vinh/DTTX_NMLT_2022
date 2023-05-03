using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_136 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 136: Tìm số chẵn cuối cùng trong mảng 1 chiều các số nguyên. Nếu mảng không có giá trị chẵn thì trả về -1");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int kq = Function.ChiSoChanCuoiCungTrongMang(a);
            Console.WriteLine(kq);
        }
    }
}
