using System;
namespace Study_Practice
{
    public class Problem_085 : Problem_000
    {
        public Problem_085()
        {
        }
        public override void Solution()
        {
            Console.WriteLine("Bài 85: Nhập vào tháng của 1 năm. Cho biết tháng thuộc quý mấy trong năm");

            int month = Function.Int_In("Nhap so thang:");

            int quarter = (month - 1) / 3 + 1;

            Console.WriteLine($"Thang {month} thuoc quy {quarter}.");
        }
    }
}

