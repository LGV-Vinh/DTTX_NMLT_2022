using System;
using System.Collections.Generic;
using System.Linq;
namespace Study_Practice
{
    public class Problem_054 : Problem_000
    {
        public Problem_054()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 54: Hãy đếm số lượng chữ số nhỏ nhất của số nguyên dương n");

            // Iput
            int n_in = Function.Int_In("Nhap so nguyen duong n:");

            // Variable
            List<int> digit = new List<int>();
            int n = n_in;
            int count = 0;

            // Get and add each digit into list
            if (n == 0)
            {
                Console.WriteLine($"Chu so nho nhat cua so nguyen duong {n_in} la 0 va co 1 so 0.");
                return;
            }
            while (n != 0)
            {
                digit.Add(n % 10);
                n /= 10;
            }
            foreach (int d in digit)
            {
                if (d == digit.Min())
                {
                    count++;
                }
            }
            Console.WriteLine($"Chu so nho nhat cua so nguyen duong {n_in} la {digit.Min()} va co {count} so.");
        }
    }
}

