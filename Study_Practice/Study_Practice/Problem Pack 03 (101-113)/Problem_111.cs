using System;
namespace Study_Practice
{
    public class Problem_111 : Problem_000
    {
        public Problem_111()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 111: Viết chương trình in ra tam giác cân có độ cao h");
            Console.WriteLine("Tam giác cân đặc nằm giữa màn hình");
            Console.WriteLine("Tam giác cân rỗng nằm giữa màn hình");
            Console.WriteLine("Tam giác vuông cân đặc");
            Console.WriteLine("Tam giác vuông cân rỗng");

            // Input
            int h = Function.Int_In("Nhap do cao h");
            int w = h * 2 - 1;

            // ___*    h = 4
            // __***   w = h * 2 - i
            // _*****  
            // *******

            // Tam giác cân đặc
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (j >= h - i - 1 && j <= h + i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Tam giác cân rỗng
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (i == h - 1 || j == h - i - 1 || j == h + i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

