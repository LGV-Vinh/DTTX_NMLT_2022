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

        public static List<int> ListUocSo(int n) // Tra ve list uoc so cua so n duoc nhap
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

        public static int Int_In(string message) // Method nhan va check input
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number >= 0) return number;
                    else Console.WriteLine("Invalid input");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        public static int UocSoChungLonNhat(int a, int b)
        {
            if (b == 0) return a;
            return UocSoChungLonNhat(b, a % b);
        }

        public static int BoiSoChungNhoNhat(int a, int b)
        {
            return (a * b) / UocSoChungLonNhat(a, b);
        }

        public static int TongGiaTriLeNhoHonN(int n)
        {
            int tong = 0;
            for (int i = 1; i < n; i += 2)
            {
                tong += i;
            }
            return tong;
        }

        public static void InCacSoNguyenLeNhoHonN(int n)
        {
            for (int i = 1; i < n; i += 2)
            {
                Console.Write($"{i} ");
            }
        }

        public static int USLN(int a, int b)
        {
            if (b == 0) return a;
            return USLN(b, a % b);
        }

        public static int BSNN(int a, int b)
        {
            return (a * b) / USLN(a, b);
        }

        public static bool KiemTraSoNguyenTo(int n)
        {
            if ( n <= 1 )
            {
                return false;
            }

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static double GiaTriTuyetDoi(double n)
        {
            if (n < 0)
            {
                n = Math.Abs(n);
                return n;
            }
            return n;
        }

        public static bool NamNhuan(int n)
        {
            if (n % 400 == 0 || (n % 100 != 0 && n % 4 == 0))
            {
                return true;
            }
            return false;
        }

        public static void DoiTien(int n)
        {
            for (int x = 0; x <= n / 1000; x++)
            {
                for (int y = 0; y <= n / 2000; y++)
                {
                    for (int z = 0; z <= n / 5000; z++)
                    {
                        if (1000*x + 2000*y + 5000*z == n)
                        {
                        Console.WriteLine($"{x} to 1000, {y} to 2000, {z} to 5000");
                        }
                    }
                }
            }
        }
    }
}

