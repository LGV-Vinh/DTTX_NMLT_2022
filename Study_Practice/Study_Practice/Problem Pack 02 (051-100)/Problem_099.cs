using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_099 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 99: Viết chương trình nhập vào 3 số thực. Hãy in 3 số ấy ra màn hình theo thứ tự tang dần mà chỉ dùng tối đa 1 biến phụ");

            Console.WriteLine("Nhap 3 so thuc:");
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            if (b > c)
            {
                double temp = b;
                b = c;
                c = temp;
            }

            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine($"3 so theo thu tu tang dan la {a}, {b}, {c}");
        }
    }
}
