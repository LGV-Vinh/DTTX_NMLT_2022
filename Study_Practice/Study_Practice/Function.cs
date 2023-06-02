using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Transactions;

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

        public static void XuatMang(double[] a)
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

        public static int ChiSoGiaTriChanNhoNhatMang(int[] a)
        {
            int minIndex = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    minIndex = i;
                    break;
                }
            }

            for (int j = minIndex + 1; j < a.Length; j++)
            {
                if (a[j] % 2 == 0 && a[j] < a[minIndex])
                {
                    minIndex = j;
                }
            }
            return minIndex;
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
                if (a[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int ChiSoAmLonNhatMang(double[] a)
        {
            int index = -1;
            
            // Tim so am dau tien
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    index = i;
                    break;
                }
            }

            // So sanh voi cac so am tiep theo
            for (int j = index + 1; j < a.Length; j++)
            {
                if (a[j] < 0 && a[j] > a[index])
                {
                    index = j;
                }
            }
            return index;
        }

        public static int ChiSoAmNhoNhatMang(double[] a)
        {
            int minIndex = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    minIndex = i;
                    break;
                }
            }

            for (int j = minIndex + 1; j < a.Length; j++)
            {
                if (a[j] < 0 && a[j] < a[minIndex])
                {
                    minIndex = j;
                }
            }
            return minIndex;
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

        public static int ChiSoDuongCuoiCungTrongMang(double[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    index = i;
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

        public static int SoNguyenToCuoiCung(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoNguyenTo(a[i]))
                {
                    index = i;
                }
            }
            return index;
        }

        public static int ChiSoNguyenToLonNhat(int[] a)
        {
            int maxIndex = -1;

            // Tim so nguyen to dau tien
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoNguyenTo(a[i]))
                {
                    maxIndex = i;
                    break;
                }
            }

            // So sanh voi cac so phia sau de tim so nguyen to lon nhat
            for (int j = maxIndex + 1; j < a.Length; j++)
            {
                if (KiemTraSoNguyenTo(a[j]) && a[j] > a[maxIndex])
                {
                    maxIndex = j;
                }
            }
            return maxIndex;
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

        public static int SoHoanThienCuoiCungMang(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoHoanThien(a[i]))
                {
                    index = i;
                }
            }
            return index;
        }

        public static int ChiSoSoHoanThienNhoNhatMang(int[] a)
        {
            int minIndex = -1;

            // Tim so hoan thien dau tien
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoHoanThien(a[i]))
                {
                    minIndex= i;
                    break;
                }
            }

            // So sanh voi cac so hoan thien sau no
            for (int j = minIndex + 1; j < a.Length; j++)
            {
                if (KiemTraSoHoanThien(a[j]) && a[j] < a[minIndex])
                {
                    minIndex = j;
                }
            }
            return minIndex;
        }

        public static double Double_In(string message)
        {
            Console.WriteLine(message);
            double n = double.Parse(Console.ReadLine());
            return n;
        }

        public static int ChiSoXaNhat(double[] a, double x)
        {
            // Gia su so dau tien la so xa nhat
            int index = 0;
            double maxKhoangCach = Math.Abs(a[0] - x);


            // So sanh voi tung so con lai
            for (int i = 1; i < a.Length; i++)
            {
                double khoangCach = Math.Abs(a[i] - x);
                if (khoangCach > maxKhoangCach)
                {
                    index = i;
                    maxKhoangCach = khoangCach;
                }
            }
            return index;
        }

        public static int ChiSoGanNhat(double[] a, double x)
        {
            // Gia su gia tri dau tien la so gan nhat
            int index = 0;
            double minKhoangCach = Math.Abs(a[0] - x);

            // So sanh voi tung so con lai
            for (int i = 1; i < a.Length; i++)
            {
                double khoangCach = Math.Abs(a[i] - x);
                if (khoangCach < minKhoangCach)
                {
                    index = i;
                    minKhoangCach = khoangCach;
                }
            }
            return index;
        }

        public static int ChiSoNhoNhatMang(double[] a)
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
        public static int ChiSoLonNhatMang(int[] a)
        {
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > a[index])
                {
                    index = i;
                }
            }
            return index;
        }

        public static int ChiSoLonNhatMang(double[] a)
        {
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > a[index])
                {
                    index = i;
                }
            }
            return index;
        }

        public static int ChiSoDauTienMangLonHon2003(double[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 2003)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int ChiSoAmCuoiMangLonHonTru1(double[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0 && a[i] > -1)
                {
                    index = i;
                }
            }
            return index;
        }

        public static int ChiSoDauTienTrongDoanXY(int[] a, int x, int y)
        {
            int index = -1;
            // Tim so nam trong doan x, y dau tien
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= x && a[i] <= y)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int ChiSoTichCua2SoLanCan(double[] a)
        {
            int index = -1;
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i-1] * a[i+1] == a[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static bool KiemTraSoChinhPhuong(int n)
        {
            int soCan = (int)Math.Sqrt(n);
            if (soCan * soCan == n)
            {
                return true;
            }
            return false;
        }

        public static int ChiSoChinhPhuongDauTienMang(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoChinhPhuong(a[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int ChiSoSoGanhDauTienMang(int[] a)
        {
            int index = -1;
            for (int i = 3; i < a.Length -2; i++)
            {
                if (a[i - 2] == a[i + 2] && a[i - 1] == a[i + 1])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int ChuSoDauTien(int n)
        {
            int digit = 0;
            while (n != 0)
            {
                digit = n % 10;
                n /= 10;
            }
            return digit;
        }
        
        public static bool KiemTraToanChuSoLe(int n)
        {
            int digit = 0;
            if (n == 0) return false;
            while (n != 0)
            {
                digit = n % 10;
                if (digit % 2 == 0)
                {
                    return false;
                }
                n /= 10;
            }
            return true;
        }

        public static int ChiSoChuSoLeDauTien(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (ChuSoDauTien(a[i]) % 2 != 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static bool KiemTraSoDang2MuK(int n)
        {
            int a = 2;
            for (int i = 1; a < n; i++)
            {
                a *= 2;
            }
            if (a == n)
            {
                return true;
            }
            return false;
        }

        public static bool KiemTraSoDangNMuK(int n, int soMuK)
        {
            int result = soMuK;
            for (int i = 1; result < n; i++)
            {
                result *= soMuK;
            }
            if (result == n)
            {
                return true;
            }
            return false;
        }

        public static int ChiSoDauTienCoDang2MuK(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoDang2MuK(a[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int ChiSoLonNhatCoDangNMuK(int[] a, int soMuK)
        {
            int index = -1;
            // Tim so co dang 5^k dau tien
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoDangNMuK(a[i], soMuK))
                {
                    index = i;
                    break;
                }
            }

            // So sanh voi cac so phia sau
            for (int j = index + 1; j < a.Length; j++)
            {
                if (KiemTraSoDangNMuK(a[j], soMuK) && a[j] > a[index])
                {
                    index = j;
                }
            }
            return index;
        }

        public static int ChiSoToanChuSoLeLonNhat(int[] a)
        {
            int index = -1;
            // Tim chu so phu hop dau tien
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraToanChuSoLe(a[i]))
                {
                    index = i;
                    break;
                }
            }

            for (int j = index + 1; j < a.Length; j++)
            {
                if (KiemTraToanChuSoLe(a[j]) && a[j] > a[index])
                {
                    index = j;
                }
            }
            return index;
        }

        public static int SoChanNhoNhatLonHonMoiGiaTriMang(int[] a)
        {
            int max = a[ChiSoLonNhatMang(a)];
            int soChanNhoNhat;
            if (max % 2 == 0)
            {
                soChanNhoNhat = max + 2;
            }
            else
            {
                soChanNhoNhat = max + 1;
            }
            return soChanNhoNhat;
        }

        public static int SoNguyenToNhoNhatLonHonMoiGiaTriMang(int[] a)
        {
            int max = a[ChiSoLonNhatMang(a)];
            int i = max + 1;
            while (KiemTraSoNguyenTo(i) == false)
            {
                i++;
            }
            return i;
        }

        public static int UocSoChungLonNhatMang(int[] a)
        {
            int uocSo = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                uocSo = UocSoChungLonNhat(uocSo, a[i]);
            }
            return uocSo;
        }

        public static int BoiSoChungNhoNhatMang(int[] a)
        {
            int boiSo = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                boiSo = BoiSoChungNhoNhat(boiSo, a[i]);
            }
            return boiSo;
        }

        public static int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }

        public static int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        public static int SoXuatHienItNhat(int[] a)
        {
            int prevCount = int.MaxValue;
            int count = 0;
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == a[i])
                    {
                        count++;
                    }
                }
                if (count < prevCount)
                {
                    prevCount = count;
                    index = i;
                }
                count = 0;
            }
            return index;
        }

        public static int ChuSoXuatHienItNhat(int[] a)
        {
            // Tao mang 10 de chua tung chu so tu 0 den 9
            int[] chuSo = new int[10];

            // Dem tung chu so roi + vao trong mang vua tao
            foreach (int number in a)
            {
                int absNumber = Math.Abs(number); // Lay gia tri tuyet doi de phong truong hop so am
                do // Dung do/while de chuong trinh van chay trong truong hop so 0
                {
                    int digit = absNumber % 10;
                    chuSo[digit]++;
                    absNumber /= 10;
                }
                while (absNumber > 0);
            }

            // Tao gia tri count MaxValue roi loop qua tung gia tri trong chuoi de tim so nho nhat
            int minCount = int.MaxValue;
            int minDigit = -1;
            for (int i = 0; i < chuSo.Length; i++)
            {
                if (chuSo[i] < minCount)
                {
                    minCount = chuSo[i];
                    minDigit = i;
                }
            }
            return minDigit;
        }

        public static void TimCapSo(double[] arr)
        {
            for (int i = 0; i < arr.Length -1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    double a = arr[i];
                    double b = arr[j];

                    if (a < b)
                    {
                        Console.WriteLine($"({a}, {b})");
                    }
                }
            }
        }

        public static void haiSoGanNhat(double[] arr)
        {
            // Gia su 2 so dau tien phu hop
            double minKhoangCach = Math.Abs(arr[0] - arr[1]);
            double a = arr[0];
            double b = arr[1];

            for (int i = 1; i < arr.Length -1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    double khoangCach = Math.Abs(arr[i] - arr[j]);
                    if (arr[i] != arr[j] && khoangCach <= minKhoangCach)
                    {
                        minKhoangCach = khoangCach;
                        a = arr[i];
                        b = arr[j];
                    }
                }
            }
            Console.WriteLine($"({a}, {b})");
        }

        public static void LietKeSoAm(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

        public static void LietKeSoAm(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

        public static void LietKeGiaTriTrongDoanXY(double[] a, double x, double y)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= x && a[i] <= y)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

        public static void LietKeGiaTriChanTrongDoanXY(int[] a, int x, int y)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0 && a[i] >= x && a[i] <= y)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

        public static void LietKeGiaTriLonHonSoNgaySau(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > Math.Abs(a[i + 1]))
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

        public static void Bai180(int[] a)
        {
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i] < Math.Abs(a[i+1]) && a[i] > Math.Abs(a[i - 1]))
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

        public static void Bai181(int[] a)
        {
            List<int> index = new List<int>();
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 2 == 0 && a[i + 1] % 2 == 0)
                {
                    index.Add(i);
                    index.Add(i + 1);
                }
            }
            index = new HashSet<int>(index).ToList();
            foreach (int id in index)
            {
                Console.WriteLine(a[id]);
            }
        }

        public static void LietKeGiaTriTraiDau(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    if (a[i] * a[i + 1] < 0)
                    {
                        Console.WriteLine(a[i]);
                    }
                }
                else if (i == a.Length - 1)
                {
                    if (a[i] * a[i - 1] < 0)
                    {
                        Console.WriteLine(a[i]);
                    }
                }
                else
                {
                    if (a[i] * a[i - 1] < 0 || a[i] * a[i + 1] < 0)
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }
        }

        public static void LietKeViTriGiaTriLonNhat(double[] a)
        {
            double max = double.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == max)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void LietKeViTriSoNguyenTo(int[] a)
        {
            int index = -1; // Gia su khong ton tai so nguyen to
            // Xuat ra vi tri so nguyen to trong mang
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoNguyenTo(a[i]))
                {
                    index = i;
                    Console.WriteLine(i);
                }
            }
            if (index < 0)
            {
                Console.WriteLine("Khong ton tai so nguyen to");
            }
        }

        public static void LietKeViTriSoChinhPhuong(int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoChinhPhuong(a[i]))
                {
                    index = i;
                    Console.WriteLine(i);
                }
            }
            if (index < 0)
            {
                Console.WriteLine("Khong ton tai so chinh phuong");
            }
        }

        public static void DichTraiXoayVong(int[] a, int k)
        {
            while (k > 0)
            {
                int temp = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    a[i - 1] = a[i];
                }
                a[a.Length - 1] = temp;
                k--;
            }
        }

        public static void Bai186(double[] a)
        {
            int index = -1; // Gia su khong ton tai so am

            // Tim so am dau tien
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    index = i;
                    break;
                }
            }

            if (index > -1)
            {
                for (int i = index; i < a.Length; i++)
                {
                    if (a[i] == a[index])
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Khong ton tai so am.");
            }
        }

        public static void Bai187(double[] a)
        {
            double min = double.MaxValue;
            int index = -1;
            // Tim gia tri duong nho nhat
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0 && a[i] < min)
                {
                    index = i;
                    min = a[i];
                }
            }

            if (index > -1)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == min)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Khong ton tai so duong");
            }
        }

        public static void Bai188(int[] a)
        {
            // Bài 188: Hãy liệt kê các vị trí chẵn lớn nhất trong mảng 1 chiều các số nguyên
            int max = int.MinValue;
            int index = -1;
            
            // Tim gia tri chan lon nhat
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0 && a[i] > max)
                {
                    index = i;
                    max = a[i];
                }
            }

            if (index > -1)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == max)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Khong ton tai so chan");
            }
        }

        public static void Bai189(int[] a)
        {
            // Bài 189: Hãy liệt kê các giá trị trong mảng 1 chiều các số nguyên có chữ số đầu tiên là chữ số lẻ
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (ChuSoDauTien(a[i]) % 2 != 0)
                {
                    index = i;
                    Console.WriteLine(a[i]);
                }
            }
            if (index == -1)
            {
                Console.WriteLine("Khong ton tai so phu hop");
            }
        }

        public static void Bai190(int[] a)
        {
            // Bài 190: Hãy liệt kê các giá trị có toàn chữ số lẻ trong mảng 1 chiều các số nguyên
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraToanChuSoLe(a[i]))
                {
                    index = 1;
                    Console.WriteLine(i);
                }
            }
            if (index == -1)
            {
                Console.WriteLine("Khong ton tai so phu hop");
            }
        }

        public static void LietKeSoCucDai(double[] a)
        {
            int flag = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    if (a[i] > a[i + 1])
                    {
                        flag = 1;
                        Console.WriteLine(a[i]);
                    }
                }
                else if (i == a.Length - 1)
                {
                    if (a[i] > a[i - 1])
                    {
                        flag = 1;
                        Console.WriteLine(a[i]);
                    }
                }
                else
                {
                    if (a[i] > a[i - 1] && a[i] > a[i + 1])
                    {
                        flag = 1;
                        Console.WriteLine(a[i]);
                    }
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Khong ton tai gia tri phu hop");
            }
        }

        public static void Bai192(int[] a)
        {
            // Bài 192: Hãy liệt kê các  giá trị trong mảng 1 chiều các số nguyên có chữ số đầu tiên là số chẵn
            int flag = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (ChuSoDauTien(a[i]) % 2 == 0)
                {
                    flag = 1;
                    Console.WriteLine(a[i]);
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Khong ton tai gia tri phu hop");
            }
        }

        public static void Bai193(int[] a)
        {
            // Bài 193: Cho mảng 1 chiều các số nguyên. Hãy viết hàm liệt kê các giá trị trong mảng có dạng 3^k. Nếu mảng không có giá trị đó thì trả về 0
            int flag = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoDangNMuK(a[i], 3))
                {
                    flag = 1;
                    Console.WriteLine(a[i]);
                }
            }
            if (flag == 0)
            {
                Console.WriteLine(0);
            }
        }

        public static void Bai194(int[] a)
        {
            // Bài 194: Cho mảng 1 chiều các số nguyên có nhiều hơn 2 giá trị. Hãy viết hàm liệt kê các cặp giá trị gần nhau nhất
            int minKhoangCach = int.MaxValue;
            
            // Loop tim khoang cach gan nhat
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (Math.Abs(a[i] - a[j]) < minKhoangCach)
                    {
                        minKhoangCach = Math.Abs(a[i] - a[j]);
                    }
                }
            }

            // Loop xuat ra cac gia tri co khoang cach gan nhat
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (Math.Abs(a[i] - a[j]) == minKhoangCach)
                    {
                        Console.WriteLine($"({a[i]} , {a[j]})");
                    }
                }
            }
        }

        public static int TongGiaTriTrongMang(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }

        public static int[,] NhapMang2Chieu()
        {
            int[,] a;
            int n, m;
            Console.Write("Nhap so dong: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            m = int.Parse(Console.ReadLine());
            a = new int[n, m];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine($"Nhap gia tri a[{i}, {j}]");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        public static void XuatMang2Chieu(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static int TongMang2Chieu(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
            return sum;
        }

        public static int DemSoNguyenToMang2Chieu(int[,] a)
        {
            int count = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (KiemTraSoNguyenTo(a[i, j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int TongGiaTriBien(int[,] a)
        {
            int sum = 0;
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == a.GetLength(0) - 1 || j == a.GetLength(1) - 1)
                    {
                        sum += a[i, j];
                    }
                }
            }
            return sum;
        }

        public static int TinhTongPhanTuBien(int[,] a)
        {
            int sum = 0;
            // Duyet qua dong 0 va dong n - 1
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sum += a[0, j];
                if (a.GetLength(0) >= 2)
                {
                    sum += a[a.GetLength(0) - 1, j];
                }
            }

            // Duyet cot dau tien va cot m -1
            for (int i = 1; i < a.GetLength(0) - 1; i++)
            {
                sum += a[i, 0];
                if (a.GetLength(1) >= 2)
                {
                    sum += a[i, a.GetLength(1) - 1];
                }
            }
            return sum;
        }

        public static void SapXepMangTang(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        public static void SapXepMang2Chieu(int[,] a)
        {
            // Chuyen doi thanh mang 1 chieu
            int[] b = new int[a.GetLength(0) * a.GetLength(1)];
            int iB = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[iB] = a[i, j];
                    iB++;
                }
            }

            // Sap xep mang 1 chieu
            Function.SapXepMangTang(b);

            // Chuyen doi ve mang 2 chieu
            iB = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = b[iB];
                    iB++;
                }
            }
        }

        public static int DemPhanTuCucDai(int[,] a)
        {
            int dem = 0;
            int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    bool isValid = true;
                    for (int k = 0; k < 8; k++)
                    {
                        if (i + dx[k] >= 0 && i + dx[k] < a.GetLength(0) &&
                            j + dy[k] >= 0 && j + dy[k] < a.GetLength(1))
                        {
                            if (a[i, j] < a[i + dx[k], j + dy[k]])
                            {
                                isValid = false;
                                break;
                            }
                        }
                    }
                    if (isValid) dem++;
                }
            }
            return dem;
        }

        public static int DemPhanTuYenNgua(int[,] a)
        {
            int dem = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    // Kiem tra max tren dong
                    bool isMaxRow = true;
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        if (a[i, j] < a[i, k])
                        {
                            isMaxRow = false;
                            break;
                        }
                    }
                    // Kiem tra min tren cot
                    if (isMaxRow)
                    {
                        bool isMinCol = true;
                        for (int k = 0; k < a.GetLength(0); k++)
                        {
                            if (a[i, j] > a[k, j])
                            {
                                isMinCol = false;
                                break;
                            }
                        }
                        if (isMinCol) dem++;
                    }
                }
            }
            return dem;
        }

        public static bool KiemTraMaTranATrongB(int[,] a, int[,] b)
        {
            for (int iB = 0; iB <= b.GetLength(0) - a.GetLength(0); iB++)
            {
                for (int jB = 0; jB <= b.GetLength(1) - a.GetLength(1); jB++)
                {
                    bool isValid = true;
                    // Xet ma tran a tai vi tri iB va jB
                    for (int iA = 0; iA < a.GetLength(0); iA++)
                    {
                        for (int jA = 0; jA < a.GetLength(1); jA++)
                        {
                            if (a[iA, jA] != b[iB + iA, jB + jA]) // iB + iA va jB + jA de offset no ve dung vi tri
                            {
                                isValid = false;
                                break;
                            }
                        }
                    }
                    if (isValid) return true;
                }
            }
            return false;
        }

        public static void MaTranConCoTongLonNhat(int[,] a, out int xMax, out int yMax, out int rMax, out int cMax)
        {
            // Gia su
            xMax = 0;
            yMax = 0;
            rMax = 1;
            cMax = 1;
            int max = a[0, 0];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    // Xet cac ma tran con bat dau tai vi tri i, j
                    for (int r = 1; r <= a.GetLength(0) - i; r++)
                    {
                        for (int c = 1; c <= a.GetLength(1) - j; c++)
                        {
                            // Tinh tong cac phan tu ma tran con cua vi tri i, j; voi so dong r va cot c
                            int sum = 0;
                            for (int iCon = 0; iCon < r; iCon++)
                            {
                                for (int jCon = 0; jCon < c; jCon++)
                                {
                                    sum += a[i + iCon, j + jCon];
                                }
                            }
                            if (sum > max)
                            {
                                max = sum;
                                xMax = i;
                                yMax = j;
                                rMax = r;
                                cMax = c;
                            }
                        }
                    }
                }
            }
        }
    }
}

