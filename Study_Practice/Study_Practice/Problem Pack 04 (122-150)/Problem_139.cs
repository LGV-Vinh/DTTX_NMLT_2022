using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_139 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 139: Tìm vị trí số hoàn thiện cuối cùng trong mảng 1 chiều các số nguyên. Nếu mảng không có số hoàn thiện thì trả về giá trị  -1");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int kq = Function.ChiSoSoHoanThienCuoiMang(a);
            Console.WriteLine(kq);
        }
    }
}
