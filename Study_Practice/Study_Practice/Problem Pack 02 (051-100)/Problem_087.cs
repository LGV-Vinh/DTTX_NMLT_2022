using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_087 : Problem_000
    {
        public Problem_087()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 87: Tìm số nguyên dương n nhỏ nhất sao cho 1 + 2 + … + n > 10000");

            int max = 10000;
            int n = 0;
            int i;

            for (i = 1; n < max; i++)
            {
                n += i;
            }
            Console.WriteLine($"n = {i-1}.");
        }
    }
}
