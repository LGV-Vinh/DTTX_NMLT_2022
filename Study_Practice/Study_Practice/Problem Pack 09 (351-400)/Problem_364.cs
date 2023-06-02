using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_364 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 364: Cho 2 ma trận A và B. Kiểm tra xem ma trận A có là ma trận con của ma trận B hay không");

            Console.WriteLine("Nhap ma tran a:");
            int[,] a = Function.NhapMang2Chieu();
            Console.WriteLine("Nhap ma tran b:");
            int[,] b = Function.NhapMang2Chieu();

            Console.WriteLine("Ma tran a:");
            Function.XuatMang2Chieu(a);
            Console.WriteLine("Ma tran b:");
            Function.XuatMang2Chieu(b);

            bool kq = Function.KiemTraMaTranATrongB(a, b);
            Console.WriteLine(kq);
        }
    }
}
