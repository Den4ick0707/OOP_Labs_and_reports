using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab_1_4_Daryev
{
    internal class PhoneClass
    {
        static public int classCounter { get; set; }=0;
        public string Company { get; set; }
        public string PhoneModel { get; set; }
        public int Price { get; set; }
        public DateTime PhoneYear { get; set; }

        public PhoneClass()
        {
            Company = "NoName";
            PhoneModel = "NoModel";
            Price = 0;
            PhoneYear = new DateTime(1950, 01, 01);
            ++classCounter;
        }
        public PhoneClass(string _company, string _phoneModel, int _price, DateTime _phoneYear)
        {
            Company = _company;
            PhoneModel = _phoneModel;
            Price = _price;
            PhoneYear = new DateTime();
            PhoneYear = _phoneYear;
            ++classCounter;
        }
        public override string ToString()
        {
            return $"Company: {Company}, Phone model: {PhoneModel}, Price: {Price}, Phone year: {PhoneYear.ToShortDateString()}";
        }

    }
}
