using System;

namespace Study_Practice;
class Program
{
    static void Main(string[] args)
    {
        // Bài 1: Tính S(n) = 1 + 2 + 3 + … + n
        // Tao input
        Console.WriteLine("Nhap so n:");
        int n = int.Parse(Console.ReadLine());

        // Tao bien
        int S = 0;

        // Loop
        for (int i = 1; i <= n; i++)
        {
            S += i;
        }
        Console.WriteLine($"S({n}) = " + S);
    }
}

