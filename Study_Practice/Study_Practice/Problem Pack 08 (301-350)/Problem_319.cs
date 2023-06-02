using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_319 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 319: Viết hàm sắp xếp ma trận các số thực tăng dần từ trên xuống dưới và từ trái sang phải");

            int[,] a = Function.NhapMang2Chieu();
            Function.XuatMang2Chieu(a);
            Console.WriteLine();
            Function.SapXepMang2Chieu(a);
            Function.XuatMang2Chieu(a);
        }
    }
}
