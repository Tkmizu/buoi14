using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi14
{
    public class Teacher : Person
    {
        public string classes;
        public double SalaryPerHour;
        public int HourPerMonth;
       
        public Teacher(string _classes, double _salaryPerHour, int _hourPerMonth)
        {
            classes = _classes;
            SalaryPerHour = _salaryPerHour;
            HourPerMonth = _hourPerMonth;
        }

        public Teacher() { }
        private bool IsValidClassName(string className)
        {
            if (string.IsNullOrEmpty(className)) return false;
            char firstChar = char.ToUpper(className[0]);
            return firstChar == 'G' || firstChar == 'H' || firstChar == 'I' || firstChar == 'K' || firstChar == 'L' || firstChar == 'M';
        }

        public override void PutInfo()
        {
            Console.WriteLine("==========================================");
            base.PutInfo();

            while (true)
            {
                Console.Write("nhập lớp: ");
                classes = Console.ReadLine();

                if (IsValidClassName(classes))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("lớp phải nhập: G, H, I, K, L, hoặc M");
                }
            }

            Console.Write("nhập lương mỗi h: ");
            double salaryPerHour;
            while (!double.TryParse(Console.ReadLine(), out salaryPerHour)) 
            {
                Console.WriteLine("nhập lại");
            }
            SalaryPerHour = salaryPerHour;

            Console.Write("nhập số giờ trong tháng: ");
            int hours;
            while(!int.TryParse(Console.ReadLine(),out hours))
            {
                Console.WriteLine("nhập lại");
            }
            HourPerMonth = hours;

            Console.WriteLine("==========================================");
        }
        public override void ShowInfo()
        {
            Console.WriteLine("==========================================");
            base.ShowInfo();
            Console.WriteLine("Lớp: " + classes);
            Console.WriteLine($"Tiền lương mỗi h dạy: {SalaryPerHour} vnđ/h");
            Console.WriteLine($"Số h dạy trong tháng: {HourPerMonth}h/month");
            Console.WriteLine($"Số thu nhập: {TotalSalary()} vnđ" );
            Console.WriteLine("==========================================");
        }

        public double TotalSalary()
        {
            double salary = SalaryPerHour * HourPerMonth;
            if(classes == "L" || classes == "M")
            {
                salary += 200000;
            }

            return salary;
        }
    }
}
