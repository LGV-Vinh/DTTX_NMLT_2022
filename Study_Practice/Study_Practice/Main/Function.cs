using System;
using System.Collections.Generic;
using System.Linq;
namespace Study_Practice
{
    public static class Function
    {
        public static int Factorial(int n) // Tao function tinh factorial cua so duoc nhap
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static List<int> listUocSo(int n) // Tra ve list uoc so cua so n duoc nhap
        {
            List<int> uocSo = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    uocSo.Add(i);
                }
            }
            return uocSo;
        }

        public static int int_in()
        {
            Console.WriteLine("Nhap so n:");
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        public static int int_in(string message)
        {
            Console.WriteLine(message);
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}

