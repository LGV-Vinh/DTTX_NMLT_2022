using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_180 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 180: Hãy liệt kê các giá trị trong mảng mà thỏa điều kiện nhỏ hơn trị tuyệt đối của giá trị đứng liền sau nó và lớn hơn trị tuyệt đối của giá trị đứng liền trước nó");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            Console.WriteLine("Cac gia tri phu hop la:");
            Function.Bai180(a);
        }
    }
}
