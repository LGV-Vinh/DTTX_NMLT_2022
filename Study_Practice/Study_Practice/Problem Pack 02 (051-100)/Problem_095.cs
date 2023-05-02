using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_095 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Viết chương trình nhập 3 số thực. Hãy thay tất cả các số âm bằng trị tuyệt đối của nó");

            Console.WriteLine("Nhap 3 so thuc");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            a = Function.GiaTriTuyetDoi(a);
            b = Function.GiaTriTuyetDoi(b);
            c = Function.GiaTriTuyetDoi(c);

            Console.WriteLine($"Gia tri tuyet doi cua chung la: {a} {b} {c}");
        }
    }
}
