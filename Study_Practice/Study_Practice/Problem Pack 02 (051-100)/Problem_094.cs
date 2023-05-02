using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_094 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 94: Viết chương trình in ra tất cả các số lẻ nhỏ hơn 100 trừ các số 5, 7, 93");

            int max = 100;

            for (int i = 1; i <= max; i += 2)
            {
                if (i == 5 || i == 7 || i == 93)
                {
                    continue;
                }
                Console.Write($"{i} ");
            }
        }
    }
}
