using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
     class Person
    {
        private string hoten;

        private string phone;


        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public Person()
        {

        }
        public Person(string hoten , string phone)
        {
            this.hoten = hoten;
            this.phone = phone;
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap ho ten : ");
            hoten = Console.ReadLine();

            Console.WriteLine("Nhap so dien thoai : ");
            phone = Console.ReadLine();
        }
        public override string ToString()
        {
            return string.Format("{0,-15}{1,-15}", hoten, phone);
        }


    }
}
