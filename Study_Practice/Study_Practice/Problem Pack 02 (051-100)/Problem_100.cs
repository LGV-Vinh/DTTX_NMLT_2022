using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_100 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 100: Viết chương trình giải phương trình bậc 2");

            int a = Function.Int_In("Nhap so nguyen a:");
            int b = Function.Int_In("Nhap so nguyen b:");
            int c = Function.Int_In("Nhap so nguyen c:");

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem.");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem.");
                    }
                }
                else
                {
                    Console.WriteLine("Phuong trinh co mot nghiem: {0}", (-c / (double)b));
                }
            }
            double delta = b * b - 4 * a * c;
            double x, x1, x2;

            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta == 0)
            {
                x = -b / (2.0 * a);
                Console.WriteLine($"Phuong trinh co 1 nghiem kep x = {x}");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine($"Phuong trinh co 2 nghiem x1 = {x1}, x2 = {x2}");
            }
        }
    }
}
