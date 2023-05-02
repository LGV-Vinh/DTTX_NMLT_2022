using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_106 : Problem_000
    {
        public override void Solution()
        {
            string[,] digitNames = new string[10, 3] {
            { "không", "", "" },
            { "một", "mươi", "mốt" },
            { "hai", "mươi", "hai" },
            { "ba", "mươi", "ba" },
            { "bốn", "mươi", "tư" },
            { "năm", "mươi", "lăm" },
            { "sáu", "mươi", "sáu" },
            { "bảy", "mươi", "bảy" },
            { "tám", "mươi", "tám" },
            { "chín", "mươi", "chín" }
        };

            Console.Write("Nhập số nguyên có 3 chữ số: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 100 && number <= 999)
            {
                int hundreds = number / 100;
                int tens = (number % 100) / 10;
                int ones = number % 10;

                Console.Write("Cách đọc của số " + number + " là ");

                if (hundreds > 0)
                {
                    Console.Write(digitNames[hundreds, 0] + " trăm ");
                }

                if (tens > 0)
                {
                    Console.Write(digitNames[tens, 1] + " ");
                }

                if (ones > 0)
                {
                    if (tens == 0 && hundreds > 0)
                    {
                        Console.Write("linh ");
                    }

                    if (ones == 1 && tens != 0 && tens != 1)
                    {
                        Console.Write("mốt");
                    }
                    else if (ones == 5 && tens != 0)
                    {
                        Console.Write("lăm");
                    }
                    else
                    {
                        Console.Write(digitNames[ones, 2]);
                    }
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Số nhập vào không hợp lệ");
            }
        }
    }
}
