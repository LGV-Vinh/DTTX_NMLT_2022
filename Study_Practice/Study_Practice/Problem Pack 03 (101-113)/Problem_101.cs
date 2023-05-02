using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Practice
{
    public class Problem_101 : Problem_000
    {
        public override void Solution()
        {
            Console.WriteLine("Bài 101: Viết chương trình nhập tháng, năm. Hãy cho biết tháng đó có bao nhiêu ngày");

            int month = Function.Int_In("Nhap so thang:");
            int year = Function.Int_In("Nhap so nam:");

            int daysInMonth = 0;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;

                case 2:
                    if (Function.NamNhuan(year))
                    {
                        daysInMonth = 29;
                    }
                    else
                    {
                        daysInMonth = 28;
                    }
                    break;

                default:
                    Console.WriteLine("Thang khong hop le:");
                    break;
            }

            if (month > 0)
            {
                Console.WriteLine($"Thang {month} nam {year} co {daysInMonth} ngay.");
            }
        }
    }
}
