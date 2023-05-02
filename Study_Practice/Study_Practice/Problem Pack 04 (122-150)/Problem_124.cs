using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_124 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 124: Viết hàm kiểm tra trong mảng các số nguyên có tồn tại giá trị chẵn nhỏ hơn 2004 hay không");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            bool kq = Function.GiaTriChanNhoHon2004(a);
            Console.WriteLine();
            Console.WriteLine(kq);
        }
    }
}
