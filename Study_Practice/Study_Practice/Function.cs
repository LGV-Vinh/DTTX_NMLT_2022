using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;

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

        public static int[] NhapMang()
        {
            int[] a;
            Console.WriteLine("Nhap so luong phan tu cua mang:");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Nhap gia tri phan tu a[{i}]");
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        public static double[] NhapMangSoThuc()
        {
            double[] a;
            Console.WriteLine("Nhap so luong phan tu cua mang:");
            int n = int.Parse(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Nhap gia tri phan tu a[{i}]");
                a[i] = double.Parse(Console.ReadLine());
            }
            return a;
        }

        public static void XuatMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }

        public static void XuatMangSoThuc(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }

        public static int ChiSoThucLonNhat(double[] a)
        {
            int maxIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > a[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static int ChiSoNguyenNhoNhat(int[] a)
        {
            int minIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < a[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static int ChiSoThucNhoNhat(double[] a)
        {
            int minIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < a[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static bool GiaTriChanNhoHon2004(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0 && a[i] < 2004)
                {
                    return true;
                }
            }
            return false;
        }

        public static int DemSoNguyenToNhoHon100(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoNguyenTo(a[i]) && a[i] < 100)
                {
                    count++;
                }
            }
            return count;
        }

        public static double TongGiaTriAmTrongMangSoThuc(double[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    sum += a[i];
                }
            }
            return sum;
        }

        public static int ChiSoAmDauTien(double[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {

            }
        }

        public static double[] SapXepMangSoThuc(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        double temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }

        public static void LietKeGiaTriChanTrongMang(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    index = i;
                    Console.Write($"{a[i]} ");
                }
            }
            
            if (index < 0)
            {
                Console.WriteLine("Khong ton tai gia tri chan");
            }
        }

        public static void LietKeChiSoAmTrongMangSoThuc(double[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    index = i;
                    Console.Write($"{i} ");
                }
            }

            if (index < 0)
            {
                Console.WriteLine("Khong ton tai gia tri am");
            }
        }

        public static int ChiSoDuongDauTienTrongMangSoThuc(double[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int ChiSoChanCuoiCungTrongMang(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    index = i;
                }
            }
            return index;
        }

        public static int SoChanDauTienMang(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int ChiSoGiaTriNhoNhatMangSoThuc(double[] a)
        {
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < a[index])
                {
                    index = i;
                }
            }
            return index;
        }

        public static int ChiSoGiaTriChanDauTienMang(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static bool KiemTraSoHoanThien(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                return true;
            }
            return false;
        }

        public static int ChiSoSoHoanThienCuoiMang(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (Function.KiemTraSoHoanThien(a[i]))
                {
                    index = i;
                }
            }
            return index;
        }

        public static double GiaTriDuongNhoNhatMangSoThuc(double[] a)
        {
            double index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    index = a[i];
                    break;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0 && a[i] < index)
                {
                    index = a[i];
                }
            }
            return index;
        }

        public static int ChiSoDuongNhoNhatMangSoThuc(double[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    index = i;
                    break;
                }
            }

            for (int i = index + 1; i < a.Length; i++)
            {
                if (a[i] > 0 && a[i] < a[index])
                {
                    index = i;
                }
            }
            return index;
        }

        public static int SoNguyenToDauTien(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoNguyenTo(a[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int SoHoanThienDauTienMang(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoHoanThien(a[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}

