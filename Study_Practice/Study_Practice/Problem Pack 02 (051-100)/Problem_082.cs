using System;
namespace Study_Practice
{
    public class Problem_082 : Problem_000
    {
        public Problem_082()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Viết chương trình tìm số lớn nhất trong 3 số thực a, b, c");

            Console.WriteLine("Nhap 3 so thuc a, b, c");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            Console.WriteLine($"So lon nhat trong 3 so thuc {a}, {b}, {c} la {max}.");
        }
    }
}

