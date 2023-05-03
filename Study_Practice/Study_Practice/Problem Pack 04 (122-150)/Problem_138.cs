using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_138 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 138: Tìm vị trí của giá trị chẵn đầu tiên trong mảng 1 chiều các số nguyên. Nếu mảng không có giá trị chẵn thì sẽ trả về -1");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int kq = Function.ChiSoGiaTriChanDauTienMang(a);
            Console.WriteLine(kq);
        }
    }
}
