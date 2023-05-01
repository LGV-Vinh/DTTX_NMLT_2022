using System;
namespace Study_Practice
{
    public class Problem_083 : Problem_000
    {
        public Problem_083()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 83: Viết chương trình nhập 2 số thực, kiểm tra xem chúng có cùng dấu hay không");

            Console.WriteLine("Nhap 2 so thuc:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a < 0 && b < 0 || a > 0 && b > 0)
            {
                Console.WriteLine($"Hai so {a} va {b} cung dau.");
            }
            else if (a == 0 || b == 0)
            {
                Console.WriteLine($"Hai so {a} va {b} khong cung dau.");
            }
            else
            {
                Console.WriteLine($"Hai so {a} va {b} khong cung dau.");
            }
        }
    }
}

