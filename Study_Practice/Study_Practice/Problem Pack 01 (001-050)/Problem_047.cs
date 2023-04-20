using System;
namespace Study_Practice
{
    public class Problem_047 : Problem_000
    {
        public Problem_047()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 47: Hãy tính tổng các chữ số chẵn của số nguyên dương n");

            // Input
            int n_in = Function.Int_In("Nhap so nguyen duong n:");

            // Variable
            int digit = 0;
            int sum = 0;
            int n = n_in;

            // Loop
            while (n != 0)
            {
                digit = n % 10;
                n /= 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }
            Console.WriteLine($"Tong cac chu so cua so nguyen duong {n_in} = {sum}.");
        }
    }
}

