using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace buoi14
{
    public class Student : Person
    {
        public string masv;
        public double total;
        public string email;
        public Student(string _masv, double _total, string _email)
        {
            masv = _masv;
            total = _total;
            email = _email;
        }

        public Student(){}
        public override void PutInfo()
        {
            Console.WriteLine("==========================================");
            base.PutInfo();
            
            do
            {
                Console.Write("nhập mã sinh viên: ");
                masv = Console.ReadLine();
                if (masv.Length > 8)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("nhập lại");
                }
            }while (masv != null);

            double Total;
            Console.Write("nhập điểm trung bình: ");
            while (!double.TryParse(Console.ReadLine(), out Total) || Total < 0 || Total > 10)
            {
                Console.WriteLine("nhập lại");
            }
            total = Total;

            do
            {
                Console.Write("nhập email: ");
                email = Console.ReadLine();
                if (IsEmail(email))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("nhập lại");
                }
            } while (true);

            Console.WriteLine("==========================================");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("==========================================");
            base.ShowInfo();  
            Console.WriteLine("mã sinh viên: "+ masv);
            Console.WriteLine("điểm trung bình: "+ total);
            Console.WriteLine("email: " + email);
            Console.WriteLine(Check());
            Console.WriteLine("==========================================");
        }

        public string Check()
        {
            if (total >= 8.0)
            {
                return "đc học bổng";
            }
            else
            {
                return "ko đc học bổng";
            }
        }

        public bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
    }
}
