using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi14
{
    public class Person
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string birthday { get; set; }
        public string hometown { get; set; }

        public Person(string Name, string Gender, string Birthday, string Hometown)
        {
            name = Name;
            gender = Gender;
            birthday = Birthday;
            hometown = Hometown;
        }
        public Person() 
        {
            
        }

        private bool DoesItEmpty(string s)
        {
            return string.IsNullOrEmpty(s);
        }
        public virtual void PutInfo()
        {
            while (true) 
            {
                Console.Write("nhập họ tên: ");
                name = Console.ReadLine();
                if (!DoesItEmpty(name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("nhập lại");
                }
            }

            while (true)
            {
                Console.Write("nhập giới tính: ");
                gender = Console.ReadLine();

                if (!DoesItEmpty(gender))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("nhập lại");
                }
            }
            

            while (true)
            {
                    Console.Write("nhập ngày sinh: ");
                    birthday = Console.ReadLine();

                    if (IsValidDate(birthday))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("nhập lại");
                    }
                }

            while (true)
            {
                Console.Write("nhập quê quán: ");
                hometown = Console.ReadLine();

                if (!DoesItEmpty(hometown))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("nhập lại");
                }
            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"tên: {name}");
            Console.WriteLine($"giới tính: {gender}");
            Console.WriteLine($"ngày sinh: {birthday}");
            Console.WriteLine($"quên quán: {hometown}");
        }

        private bool IsValidDate(string date)
        {
            //định dạng ngày cần kiểm tra
            string format = "dd/MM/yyyy";
            DateTime parsedDate;

            if(string.IsNullOrEmpty(date))
                return false;

            //kiểm tra định dạng ngày và tính hợp lệ của ngày
            return DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);
        }
    }
}
