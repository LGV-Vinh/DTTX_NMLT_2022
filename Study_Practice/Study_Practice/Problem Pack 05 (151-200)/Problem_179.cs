using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_179 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 179: Hãy liệt kê các giá trị trong mảng mà thỏa điều kiện lớn hơn giá trị tuyệt đối của giá trị đứng liền sau nó");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            Console.WriteLine($"Cac gia tri lon hon gia tri tuyet doi cua so ngay sau no la:");
            Function.LietKeGiaTriLonHonSoNgaySau(a);
        }
    }
}
