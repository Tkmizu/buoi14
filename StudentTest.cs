using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi14
{
    public class StudentTest
    {
        public static void _StudentTest()
        {
            List<Student> list = new List<Student>()
            {
            new Student { name = "Blade", gender = "male", birthday = "04/12/2003", hometown = "Hà nội", masv = "ph25976", total = 5, email = "a@gmail.com"},
            new Student { name = "Garen", gender = "male", birthday = "04/12/2003", hometown = "Hà nội", masv = "ph25977", total = 10, email = "a@gmail.com"},
            new Student { name = "Lengar", gender = "male", birthday = "04/12/2003", hometown = "Hà nội", masv = "ph25978", total = 9, email = "a@gmail.com"},
            new Student { name = "Chalice", gender = "male", birthday = "04/12/2003", hometown = "Hà nội", masv = "ph25979", total = 7, email = "a@gmail.com"},
            };
            
            int n;
            do
            {
                Console.WriteLine("nhập menu: ");
                Console.WriteLine("1. Nhập n các sinh viên với các thông tin đầy đủ");
                Console.WriteLine("2. Hiển thị tất cả sinh viên ra màn hình");
                Console.WriteLine("3. Hiển thị sinh viên có điểm trung bình cao nhất và thấp nhất");
                Console.WriteLine("4. Tìm kiếm sinh viên theo mã sinh viên");
                Console.WriteLine("5. Hiển thị tất cả sinh viêm theo thứ tự trong bảng chữ cái");
                Console.WriteLine("6. Hiển thị thông tin tất cả sinh viên đc học bổng, xếp thứ tự điểm từ cao xuống thấp");
                Console.WriteLine("7. Thoát");

                Console.Write("Nhập số để chọn chương trình: ");
                n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            Console.Write("Nhập số lượng sinh viên cần nhập: ");
                            int r;
                            while (!int.TryParse(Console.ReadLine(), out r) || r <= 0)
                            {
                                Console.Write("Vui lòng nhập một số nguyên dương: ");
                            }

                            for (int i = 0; i < r; i++)
                            {
                                Student st = new Student();
                                st.PutInfo();
                                list.Add(st);
                            }
                            break;

                        case 2:
                            foreach (Student st2 in list)
                            {
                                st2.ShowInfo();
                            }
                            break;

                        case 3:

                            double highestTotal = list.Max(s => s.total);
                            var topStudent = list.Where(s => s.total == highestTotal);

                            Console.WriteLine("sinh viên có điểm trung bình cao nhất:");
                            foreach (Student st2 in topStudent)
                            {
                                st2.ShowInfo();
                            }

                            double lowestTotal = list.Min(s => s.total);
                            var bottomStudent = list.Where(s => s.total == lowestTotal);

                            Console.WriteLine("sinh viên có điểm trung bình thấp nhất:");
                            foreach (Student st2 in bottomStudent)
                            {
                                st2.ShowInfo();
                            }
                            break;

                        case 4:
                            Console.Write("nhập mã sinh viên: ");
                            string id = Console.ReadLine();
                            
                            var student = list.Where(s => s.masv == id);

                            foreach (Student st2 in student)
                            {
                                st2.ShowInfo();
                            }
                            break;

                        case 5:
                            Console.WriteLine("danh sách sinh viên đc sắp xếp theo thứ tự bảng chữ cái: ");
                            var sortedByName = list.OrderBy(s => s.name);

                            foreach (Student st2 in sortedByName)
                            {
                                st2.ShowInfo();
                            }
                            break;

                        case 6:
                            Console.WriteLine("danh sách sinh viên đc sắp xếp theo học bổng: ");
                            var sortedBySchoolarShip = list.OrderByDescending(s => s.total);

                            foreach (Student st2 in sortedBySchoolarShip)
                            {
                                st2.ShowInfo();
                            }
                            break;

                        case 7:
                            Console.WriteLine("Shutting down");
                            break;

                        default:
                            Console.WriteLine("chỉ nhập từ 1 -> 7");
                            break;
                    }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while (n != 7);
            
                   
        }
    }
}
