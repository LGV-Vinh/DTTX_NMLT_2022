using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_173 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 173 (*): Cho mảng 1 chiều các số nguyên. Hãy  viết hàm tìm chữ số xuất hiện ít nhất trong mảng");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int chiSo = Function.TimChuSoXuatHienItNhat(a);
            Console.WriteLine(chiSo);
        }
    }
}
