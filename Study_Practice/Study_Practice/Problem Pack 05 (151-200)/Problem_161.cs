using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_161 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 161: Cho mảng 1 chiều các số nguyên, hãy tìm giá trị đầu tiên nằm trong khoảng [x, y] cho trước. Nếu mảng không có giá trị thỏa điều kiện trên thì trả về -1");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int x = Function.Int_In("Nhap gia tri x:");
            int y = Function.Int_In("Nhap gia tri y:");
            int chiSo = Function.ChiSoDauTienTrongDoanXY(a, x, y);
            int kq = (chiSo > -1) ? a[chiSo] : chiSo;
            Console.WriteLine(kq);
        }
    }
}
