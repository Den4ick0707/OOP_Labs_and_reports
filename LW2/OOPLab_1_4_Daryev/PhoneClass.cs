using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab_1_4_Daryev
{
    public partial class PhoneClass
    {
        static public int classCounter { get; set; } = 0;
        public string Company { get; set; }
        public string PhoneModel { get; set; }
        public int Price { get; set; }
        public DateTime PhoneYear { get; set; }
        

        //-------------------------- Overloaded operators -------------------------
        public static bool operator ==(PhoneClass obj1, PhoneClass obj2)
        {
            if (obj1.Company == obj2.Company && obj1.PhoneModel == obj2.PhoneModel && obj1.Price == obj2.Price && obj1.PhoneYear == obj2.PhoneYear)
                return true;
            else return false;
        }
        public static bool operator !=(PhoneClass obj1, PhoneClass obj2)
        {
            if (obj1.Company != obj2.Company && obj1.PhoneModel != obj2.PhoneModel && obj1.Price != obj2.Price && obj1.PhoneYear != obj2.PhoneYear)
                return true;
            else return false;
        }
        public static implicit operator string(PhoneClass obj)
        {
            return $"Company: {obj.Company}, Phone model: {obj.PhoneModel}, Price: {obj.Price}, Phone year: {obj.PhoneYear.ToShortDateString()}";
        }
        public static int operator +(PhoneClass obj1, PhoneClass obj2)
        {
            return obj1.Price + obj2.Price;
        }
        public static int operator -(PhoneClass obj1, PhoneClass obj2)
        {
            return obj1.Price - obj2.Price;
        }
       public static  PhoneClass  operator ++(PhoneClass obj)
        {
            return new PhoneClass(obj.Company,obj.PhoneModel,obj.Price++);
        }
        public static PhoneClass operator --(PhoneClass obj)
        {
            return new PhoneClass(obj.Company, obj.PhoneModel, obj.Price--);
        }
        public override string ToString()
        {
            return $"Company: {Company}, Phone model: {PhoneModel}, Price: {Price}, Phone year: {PhoneYear.ToShortDateString()}";
        }
    }
}
