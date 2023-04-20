using System;
namespace Study_Practice
{
    public class Problem_065 : Problem_000
    {
        public Problem_065()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 65: Giải phương trình bậc 2"); // ax^2 + bx + c = 0

            // Input
            int a = Function.Int_In("Nhap so nguyen a:");
            int b = Function.Int_In("Nhap so nguyen b:");
            int c = Function.Int_In("Nhap so nguyen c:");

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh co vo so nghiem.");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem.");
                    }
                }
                else
                {
                    Console.WriteLine("Phuong trinh co mot nghiem: {0}.", (-c / (double)b));
                }
            }

            // Tinh delta
            double delta = b * b - 4 * a * c;
            double x, x1, x2;

            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta == 0)
            {
                x = -b / (double)2 * a;
                Console.WriteLine($"Phuong trinh co nghiem kep {x}.");
            }
            else // delta > 0
            {
                x1 = (-b + Math.Sqrt(delta)) / ((double)2 * a);
                x2 = (-b - Math.Sqrt(delta)) / ((double)2 * a);
                Console.WriteLine($"Phuong trinh co nghiem phan biet x1 = {x1} va x2 = {x2}.");
            }
        }
    }
}

