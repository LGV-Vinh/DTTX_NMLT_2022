using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    internal class Problem_090 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 90: Viết chương trình tìm số nguyên dương m lớn nhất sao cho 1 + 2 + … + m < N");

            int n = Function.Int_In("Nhap so nguyen duong N");
            int m;
            int sum = 0;
            for (m = 1; m < n; m++)
            {
                sum += m;
                if (sum >= n)
                {
                    m = m - 1;
                    break;
                }
            }
            Console.WriteLine(m);
        }
    }
}
