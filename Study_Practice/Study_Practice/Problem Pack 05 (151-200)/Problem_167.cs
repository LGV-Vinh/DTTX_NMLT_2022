using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_167 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 167: Hãy tìm giá trị thỏa điều kiện toàn chữ số lẻ và là giá trị lớn nhất thỏa điều kiện ấy trong mảng 1 chiều các số nguyên. Nếu mảng không có giá trị thỏa điều kiện trên thì trả về 0");

            int[] a = Function.NhapMang();
            Function.XuatMang(a);
            Console.WriteLine();
            int chiSo = Function.ChiSoToanChuSoLeLonNhat(a);
            int kq = (chiSo > -1) ? a[chiSo] : 0;
            Console.WriteLine(kq);
        }
    }
}
