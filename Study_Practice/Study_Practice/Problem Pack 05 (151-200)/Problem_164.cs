using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_164 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 164: Cho mảng 1 chiều các số nguyên. Hãy tìm giá trị đầu tiên thỏa mãn tính chất số gánh");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int chiSo = Function.ChiSoSoGanhDauTienMang(a);
            Console.WriteLine(chiSo);
        }
    }
}
