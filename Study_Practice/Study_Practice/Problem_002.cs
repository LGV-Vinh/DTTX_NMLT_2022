using System;
namespace Study_Practice
{
	public class Problem_002:Problem_000
	{
		public Problem_002()
		{
		}
        public override void Solution()
        {
            // Bài 2: Tính S(n) = 1^2 + 2^2 + … + n^2
            // Tao input
            Console.WriteLine("Nhap so n:");
            int n = int.Parse(Console.ReadLine());

            // Tao bien
            int S = 0;

            // Loop
            for (int i = 1; i <= n; i++)
            {
                S += (i * i);
            }
            Console.WriteLine($"Tong cua S({n}) = " + S);
        }
    }
}

