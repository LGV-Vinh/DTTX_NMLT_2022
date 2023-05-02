using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_088 : Problem_000
    {
        public Problem_088()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 88: Hãy sử dụng vòng lặp for để xuất tất cả các ký tự từ A đến Z");

            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
