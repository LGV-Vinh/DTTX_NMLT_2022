using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_103 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 103: Viết chương trình nhập vào 1 ngày ( ngày, tháng, năm). Tìm ngày trước ngày vừa nhập (ngày, tháng, năm)");

            int day = Function.Int_In("Nhap ngay:");
            int month = Function.Int_In("Nhap thang:");
            int year = Function.Int_In("Nhap nam:");

            int daysInMonth;

            switch (month)
            {
                case 3:
                    daysInMonth = Function.NamNhuan(year) ? 29 : 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 31;
                    break;
                default:
                    daysInMonth = 30;
                    break;
            }

            if (day == 1)
            {
                if (month == 1)
                {
                    year--;
                    month = 12;
                    day = daysInMonth;
                }
                else
                {
                    month--;
                    day = daysInMonth;
                }
            }
            else
            {
                day--;
            }
            Console.WriteLine($"Ngay truoc do la {day}/{month}/{year}");
        }
    }
}
