using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_196 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 196: Liệt kê các số âm trong mảng 1 chiều các số nguyên");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            Console.WriteLine("Cac gia tri phu hop la:");
            Function.LietKeSoAm(a);
        }
    }
}
