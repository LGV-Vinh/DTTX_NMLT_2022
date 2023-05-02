using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_097 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 97: Viết chương trình nhập 3 cạnh của 1 tam giác, cho biết đó là tam giác gì");

            Console.WriteLine("Nhap do dai 3 canh tam giac:");

            Console.Write("Canh 1: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Canh 2: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Canh 3: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c || b + c > a || c + a > b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Day la tam giac deu");
                }
                else if (a == b || b == c || c == a)
                {
                    if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
                    {
                        Console.WriteLine("Day la tam giac vuong can");
                    }
                    else
                    {
                        Console.WriteLine("Day la tam giac can");
                    }
                }
                else if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
                {
                    Console.WriteLine("Day la tam giac vuong");
                }
                else
                {
                    Console.WriteLine("Day la tam giac thuong");
                }
            }
            else
            {
                Console.WriteLine("Day khong phai tam giac");
            }
        }
    }
}
