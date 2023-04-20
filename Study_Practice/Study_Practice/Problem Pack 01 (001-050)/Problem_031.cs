using System;
namespace Study_Practice
{
    public class Problem_031 : Problem_000
    {
        public Problem_031()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 31: Cho số nguyên dương n. Kiểm tra xem n có phải là số nguyên tố hay không");

            // Tao input
            int n = Function.Int_In("Nhap so nguyen n:");

            // Kiem tra so nguyen to
            if (n <= 1)
            {
                Console.WriteLine($"Bai 031: {n} khong phai la so nguyen to.");
                return;
            }

            // List uoc so
            List<int> uocSo = Function.ListUocSo(n);

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"Cac uoc so cua {n} la:");
                    foreach (int uoc in uocSo)
                    {
                        Console.Write(uoc + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Bai 031: {n} khong phai la so nguyen to.");
                }
            }
            Console.WriteLine($"Cac uoc so cua {n} la:");
            foreach (int uoc in uocSo)
            {
                Console.Write(uoc + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Bai 031: {n} la so nguyen to.");



            //static double soNguyenTo(int i, int n, List<int> uocSo)
            //{
            //    if (n % i == 0)
            //    {
            //        foreach (int uoc in uocSo)
            //        {
            //            Console.Write(uoc + " ");
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine($"{n} khong phai la so nguyen to.");
            //        return 0;
            //    }
            //    if (i > Math.Sqrt(n))
            //    {
            //        foreach (int uoc in uocSo)
            //        {
            //            Console.Write(uoc + " ");
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine($"{n} la so nguyen to.");
            //        return 0;
            //    }
            //    return soNguyenTo(i + 1, n, uocSo);
            //}

            //soNguyenTo(2, n, uocSo);
        }
    }
}

