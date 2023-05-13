using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_175 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 175 (*): Cho mảng số thực có nhiều hơn 2 giá trị và các giá trị trong mảng khác nhau từng đôi một. Hãy viết hàm tìm 2 giá trị gần nhau nhất trong mảng (Lưu ý: Mảng có các giá trị khác nhau từng đôi một còn có tên là mảng phân biệt)");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMang(a);
            Console.WriteLine();
            Function.haiSoGanNhat(a);
        }
    }
}
