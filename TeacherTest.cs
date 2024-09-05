using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi14
{
    public class TeacherTest
    {
        public static void _TeacherTest()
        {
            List<Teacher> list = new List<Teacher>()
            {
            new Teacher { name = "Kuuga", gender = "male", birthday = "04/12/2003", hometown = "Hà nội", classes = "G", SalaryPerHour = 100000, HourPerMonth = 40},
            new Teacher { name = "Agito", gender = "male", birthday = "04/12/2003", hometown = "Hà nội", classes = "H", SalaryPerHour = 200000, HourPerMonth = 30},
            new Teacher { name = "Ryuki", gender = "male", birthday = "04/12/2003", hometown = "Hà nội", classes = "L", SalaryPerHour = 300000, HourPerMonth = 60},
            new Teacher { name = "Faiz", gender = "male", birthday = "04/12/2003", hometown = "Hà nội", classes = "M", SalaryPerHour = 400000, HourPerMonth = 55},
            };

            int n;
            do
            {
                Console.WriteLine("nhập menu: ");
                Console.WriteLine("1. Nhập n các giáo viên với các thông tin đầy đủ");
                Console.WriteLine("2. Hiển thị tất cả giáo viên ra màn hình");
                Console.WriteLine("3. Hiển thị giáo viên có giờ dạy cao nhất");
                Console.WriteLine("4. Hiển thị giáo viên có lương nhận cao nhất");
                Console.WriteLine("5. thoát");

                Console.Write("Nhập số để chọn chương trình: ");
                n = int.Parse(Console.ReadLine());

                switch (n) 
                {
                        case 1:
                        Console.Write("Nhập số lượng giáo viên cần nhập: ");
                        int r;
                        while (!int.TryParse(Console.ReadLine(), out r) || r <= 0)
                        {
                            Console.Write("Vui lòng nhập một số nguyên dương: ");
                        }

                        for (int i = 0; i < r; i++)
                        {
                            Teacher tc = new Teacher();
                            tc.PutInfo();
                            list.Add(tc);
                        }
                        break;

                        case 2:
                        foreach (Teacher tc2 in list)
                        {
                            tc2.ShowInfo();
                        }
                        break;

                        case 3:
                        int hours = list.Max(s => s.HourPerMonth);
                        var topTeacher = list.Where(s => s.HourPerMonth == hours);

                        Console.WriteLine("giảng viên có h dạy trong tháng cao nhất:");
                        foreach (Teacher tc2 in topTeacher)
                        {
                            tc2.ShowInfo();
                        }
                        break;

                        case 4:
                        double salary = list.Max(s => s.TotalSalary());
                        var topTeacher2 = list.Where(s => s.TotalSalary() == salary);

                        foreach (Teacher tc2 in topTeacher2)
                        {
                            tc2.ShowInfo();
                        }
                        break;

                        case 5:
                        Console.WriteLine("Shutting down");
                        break;

                        default:
                        Console.WriteLine("chỉ nhập từ 1 -> 5");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while (n != 5);
        }
    }
}
