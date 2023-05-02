using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_102 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 102: Viết chương trình nhập vào 1 ngày ( ngày, tháng, năm). Tìm ngày kế ngày vừa nhập (ngày, tháng, năm)");

            int day = Function.Int_In("Nhap ngay:");
            int month = Function.Int_In("Nhap thang:");
            int year = Function.Int_In("Nhap nam:");

            int daysInMonth;
            
            switch (month)
            {
                case 2:
                    daysInMonth = Function.NamNhuan(year) ? 29 : 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                default:
                    daysInMonth = 31;
                    break;
            }

            if (day == daysInMonth)
            {
                if(month == 12)
                {
                    year++;
                    month = 1;
                    day = 1;
                }
                else
                {
                    month++;
                    day = 1;
                }
            }
            else
            {
                day++;
            }

            Console.WriteLine($"Ngay ke tiep la: {day}/{month}/{year}");
        }
    }
}
