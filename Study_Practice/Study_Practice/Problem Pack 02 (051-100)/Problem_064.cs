using System;
namespace Study_Practice
{
    public class Problem_064 : Problem_000
    {
        public Problem_064()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 64: Giải phương trình bậc 1"); // ax + b = 0

            // Input
            int a = Function.Int_In("Nhap so a:");
            int b = Function.Int_In("Nhap so b:");

            if (a == 0)
            {
                if (b == 0)
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
                double x = -b / (double)a;
                Console.WriteLine($"Phuong trinh co nghiem = {x}.");
            }
        }
    }
}

