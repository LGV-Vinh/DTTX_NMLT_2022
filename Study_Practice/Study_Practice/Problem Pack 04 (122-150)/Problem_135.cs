using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_135 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 135: Viết hàm tìm giá trị dương đầu tiên trong mảng 1 chiều các số thực. Nếu mảng không có giá trị dương thì trả về -1");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMangSoThuc(a);
            Console.WriteLine();
            int kq = Function.ChiSoDuongDauTienTrongMangSoThuc(a);
            Console.WriteLine(kq);

        }
    }
}
