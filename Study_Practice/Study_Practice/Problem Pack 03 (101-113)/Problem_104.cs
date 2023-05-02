using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_104 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 104: Viết chương trình nhập ngày, tháng, năm. Tính xem ngày đó là ngày thứ bao nhiêu trong năm");

            int day = Function.Int_In("Nhap ngay:");
            int month = Function.Int_In("Nhap thang:");
            int year = Function.Int_In("Nhap nam:");

            int dayOfYear = day;

            for (int i = 1; i < month; i++)
            {
                dayOfYear += DateTime.DaysInMonth(year, i);
            }

            Console.WriteLine($"La ngay thu {dayOfYear}");
        }
    }
}
