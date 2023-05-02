using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_093 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 93: Viết chương trình kiểm tra 1 số có phải là số nguyên tố hay không");

            int n = Function.Int_In("Nhap so nguyen n:");

            if (Function.KiemTraSoNguyenTo(n))
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
        }
    }
}
