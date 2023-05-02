using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_089 : Problem_000
    {
        public Problem_089() { }
        public override void Solution()
        {
            Console.WriteLine("Bài 89: Viết chương trình tính tổng các giá trị lẻ nguyên dương nhỏ hơn N");

            int n = Function.Int_In("Nhap so nguyen duong N:");

            int tong = Function.TongGiaTriLeNhoHonN(n);

            Console.WriteLine(tong);
        }
    }
}
