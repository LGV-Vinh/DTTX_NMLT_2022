using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_159 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 159: Cho mảng 1 chiều các số thực, hãy tìm giá trị đầu tiên lớn hơn giá trị 2003. Nếu mảng không có giá trị thỏa điều kiện trên thì trả về  -1");

            double[] a = Function.NhapMangSoThuc();
            Function.XuatMang(a);
            Console.WriteLine();
            int chiSo = Function.ChiSoDauTienMangLonHon2003(a);
            double kq = (chiSo > -1) ? a[chiSo] : chiSo;
            Console.WriteLine(kq);
        }
    }
}
