using System;
using System.Collections.Generic;
using System.Linq;
namespace Study_Practice
{
    public class Problem_056 : Problem_000
    {
        public Problem_056()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 56: Hãy kiểm tra số nguyên dương n có toàn chữ số lẻ hay không");

            // Iput
            int n_in = Function.Int_In("Nhap so nguyen duong n:");

            // Variable
            List<int> digit = new List<int>();
            int n = n_in;

            // Get and add each digit into list
            if (n == 0)
            {
                Console.WriteLine($"So nguyen duong {n_in} KHONG co toan bo chu so le.");
                return;
            }
            while (n != 0)
            {
                digit.Add(n % 10);
                n /= 10;
            }
            foreach (int d in digit)
            {
                if (d % 2 == 0)
                {
                    Console.WriteLine($"So nguyen duong {n_in} KHONG co toan bo chu so le.");
                    return;
                }
            }
            Console.WriteLine($"So nguyen duong {n_in} co toan bo chu so le.");
        }
    }
}

