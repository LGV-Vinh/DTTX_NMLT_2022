using System;
namespace Study_Practice
{
    public class Problem_043 : Problem_000
    {
        public Problem_043()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 43: Hãy đếm số lượng chữ số của số nguyên dương n");

            // Input
            int n = Function.int_in("Nhap so nguyen duong n");

            // Convert to string and get length
            int length = n.ToString().Length;

            Console.WriteLine($"So nguyen duong n co {length} chu so.");
        }
    }
}

