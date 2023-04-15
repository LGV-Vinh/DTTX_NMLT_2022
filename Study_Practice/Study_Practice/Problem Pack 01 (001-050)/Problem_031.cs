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
            Console.WriteLine("Nhap so nguyen duong n:");
            long n = long.Parse(Console.ReadLine());

            //// Kiem tra so nguyen to
            //if (n <= 1)
            //{
            //    Console.WriteLine($"Bai 031: {n} khong phai la so nguyen to.");
            //    return;
            //}

            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            // List uoc so
            List<long> uocSo = Function.listUocSoLong(n);

            //for (long i = 2; i <= Math.Sqrt(n); i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine($"Cac uoc so cua {n} la:");
            //        foreach (long uoc in uocSo)
            //        {
            //            Console.Write(uoc + " ");
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine($"Bai 031: {n} khong phai la so nguyen to.");
            //        watch.Stop();

            //        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            //        return;
            //    }
            //}
            //Console.WriteLine($"Cac uoc so cua {n} la:");
            //foreach (long uoc in uocSo)
            //{
            //    Console.Write(uoc + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Bai 031: {n} la so nguyen to.");



            static double soNguyenTo(int i, long n, List<long> uocSo)
            {
                if (n % i == 0)
                {
                    foreach (long uoc in uocSo)
                    {
                        Console.Write(uoc + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"{n} khong phai la so nguyen to.");
                    return 0;
                }
                if (i > Math.Sqrt(n))
                {
                    foreach (long uoc in uocSo)
                    {
                        Console.Write(uoc + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"{n} la so nguyen to.");
                    return 0;
                }
                return soNguyenTo(i + 1, n, uocSo);
            }

            soNguyenTo(2, n, uocSo);
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}

