using System;
namespace Study_Practice
{
    public class Problem_033 : Problem_000
    {
        public Problem_033()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 33: Tính S(n) = CanBac2(2+CanBac2(2+….+CanBac2(2 + CanBac2(2)))) có n dấu căn");

            // Tao input
            int n = Function.int_in("Nhap so nguyen n:");

            // Tao bien
            double S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                double temp = S;
                S = Math.Sqrt(2 + temp);
            }
            Console.WriteLine("Bai 033: S({0}) = {1}.", n, S);

            //    static double SqrtTimes(double S, int n)
            //    {
            //        double step = Math.Sqrt(2);
            //        if (n < 1)
            //        {
            //            Console.WriteLine(S);
            //            return 0;
            //        }
            //        return SqrtTimes(Math.Sqrt(2 + S), n-1);
            //    }
            //    SqrtTimes(0, n);
        }
    }
}

