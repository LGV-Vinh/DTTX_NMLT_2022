using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
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

            // So sanh voi cac so phia sau
            for (int j = index + 1; j < a.Length; j++)
            {
                if (a[j] >= x && a[j] <= y && a[j] < a[index])
                {
                    index = j;
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
            int soNguyenToNhoNhat;
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
    }
}

