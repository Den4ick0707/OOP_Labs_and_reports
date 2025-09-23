using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_WinForm_Daryev
{
    internal class PhoneClass
    {
        public string phoneName { get; set; }
        public string phoneModel { get; set; }
        public DateTime phoneYear { get; set; }
        public double phonePrice { get; set; }

        public PhoneClass()
        {
            phoneName = "default";
            phoneModel = "default";
            phoneYear = new DateTime(1960, 01, 01);
            phonePrice = 0;
        }
        public PhoneClass(string name, string number, DateTime year, double price)
        {
            phoneName = name;
            phoneModel = number;

            if (year <= new DateTime(1960, 01, 01))
            {
                phoneYear = new DateTime(1960, 01, 01);
            }
            else if (year >= DateTime.Now)
            {
                phoneYear = DateTime.Now;
            }
            else phoneYear = year;

            phonePrice = price;
        }

        // ----------------------------- Operator Overloading -----------------------------
        static public bool operator >(PhoneClass phone1, PhoneClass phone2)
        {
            return phone1.phonePrice > phone2.phonePrice;
        }
        static public bool operator <(PhoneClass phone1, PhoneClass phone2)
        {
            return phone1.phonePrice < phone2.phonePrice;
        }
        static public bool operator ==(PhoneClass phone1, PhoneClass phone2)
        {
            return phone1.Equals(phone2);
        }
        static public bool operator !=(PhoneClass phone1, PhoneClass phone2)
        {
            return !phone1.Equals(phone2);
        }
        static public bool operator >=(PhoneClass phone1, PhoneClass phone2)
        {
            return phone1.phonePrice >= phone2.phonePrice;
        }
        static public bool operator <=(PhoneClass phone1, PhoneClass phone2)
        {
            return phone1.phonePrice <= phone2.phonePrice;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is PhoneClass phone)
            {
                return this.phoneName.Equals(phone.phoneName, StringComparison.OrdinalIgnoreCase)
                    && this.phoneModel.Equals(phone.phoneModel, StringComparison.OrdinalIgnoreCase)
                    && this.phoneYear == phone.phoneYear
                    && this.phonePrice == phone.phonePrice;
            }
            return false;
        }
        public override string ToString()
        {
            return string.Format("{0,-15} {1,-15} {2,10} {3,10}",
                this.phoneName, this.phoneModel, this.phoneYear, this.phonePrice);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(phoneName.GetHashCode(), phoneModel.GetHashCode(), phoneYear.GetHashCode(), phonePrice.GetHashCode());
        }
        static public PhoneClass operator ++(PhoneClass phone)
        {
            phone.phonePrice++;
            return phone;
        }
        static public PhoneClass operator --(PhoneClass phone)
        {
            if (phone.phonePrice > 0)
                phone.phonePrice--;

            return phone;
        }
        static public PhoneClass operator +(PhoneClass phone, double value)
        {
            phone.phonePrice += value;
            return phone;
        }
        static public PhoneClass operator -(PhoneClass phone, double value)
        {
            if (phone.phonePrice - value >= 0)
                phone.phonePrice -= value;
            else
                phone.phonePrice = 0;
            return phone;
        }

        //---------------------------------------------------------------------------------


    }
}