using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBień_Wypożyczalnia.MyClasses
{
    //Definicja klasy Person
     public abstract class Person
    {
        private string _firstName;
        private string _lastName;
        private string _pesel;
        private string _gender;
        private int _id;
        private DateTime _birthDate;
        private static int _noOfPersons = 0;
        private bool _skis;
        private bool _helmet;
        private bool _accessories;
        private bool _snowboard;
        public int _price;
        public Bitmap _picture;
        private int _skisPrice;
        private int _helmetPrice;
        private int _accessoriesPrice;
        private int _snowboardPrice;
        public int _overallPrice;

        public int Price { get => _price; set => _price = value; }

        public Bitmap Photo
        {
            get => _picture;
        }

        public Person()
        {
            _firstName = "-";
            _lastName = "-";
            _pesel = "-";
            _gender = "-";
            _noOfPersons++;
            _id = _noOfPersons;
            _birthDate = DateTime.Now;
            _skis = false;
            _helmet = false;
            _accessories = false;
            _snowboard = false;
            _price = 0;
            _skisPrice = 0;
            _helmetPrice = 0;
            _accessoriesPrice = 0;
            _snowboardPrice = 0;
            _overallPrice = 0;
        }

        public Person(string firstName, string lastName, DateTime birthDate, string pesel, string gender, bool skis, bool helmet, bool accessories, bool snowboard, Bitmap picture)
        {
            _firstName = firstName;
            _lastName = lastName;
            _pesel = pesel;
            _gender = gender;
            _noOfPersons++;
            _id = _noOfPersons;
            _birthDate = birthDate;
            _skis = skis;
            _helmet = helmet;
            _accessories = accessories;
            _snowboard = snowboard;
            _picture = picture;
        }

        public Person(Person p)
        {
            _noOfPersons += 1;
            _firstName = p._firstName;
            _lastName = p._lastName;
            _pesel = p._pesel;
            _gender = p._gender;
            _id = _noOfPersons;
            _birthDate = p._birthDate;
            _skis = p._skis;
            _helmet = p._helmet;
            _accessories = p._accessories;
            _snowboard = p._snowboard;
            _price = p._price;
            _picture = p._picture;
        }

        public virtual List<string> GetInfo()
        {
            List<string> pinfo = new List<string>();
            pinfo.Add("ID klienta:\t\t\t " + _id);
            pinfo.Add("Imię:\t\t\t\t " + _firstName);
            pinfo.Add("Nazwisko:\t\t\t " + _lastName);
            pinfo.Add("Płeć:\t\t\t\t " + _gender);
            pinfo.Add("Data ur:\t\t\t\t " + _birthDate);
            pinfo.Add("Wiek:\t\t\t\t " + GetAge());
            pinfo.Add("PESEL:\t\t\t\t " + _pesel);
            pinfo.Add("Wypożyczył narty:\t\t\t " + (_skis ? "Tak" : "Nie"));
            pinfo.Add("Wypożyczył snowboard:\t\t " + (_snowboard ? "Tak" : "Nie"));
            pinfo.Add("Wypożyczył kask:\t\t\t " + (_helmet ? "Tak" : "Nie"));
            pinfo.Add("Wypożyczył kijki do nart:\t\t " + (_accessories ? "Tak" : "Nie"));
            GetPrice();
            GetOverallPrice();
            return pinfo;
        }

        public int GetPrice()
        {
            if (_skis == true)
            {
                _skisPrice = 20;
            }
            if (_snowboard == true)
            {
                _snowboardPrice = 25;
            }
            if (_helmet == true)
            {
                _helmetPrice = 10;
            }
            if (_accessories == true)
            {
                _accessoriesPrice = 15;
            }

            _price = _skisPrice + _snowboardPrice + _helmetPrice + _accessoriesPrice;

            return 0;
        }

        public int GetOverallPrice()
        {
            if (_skis == true)
            {
                _overallPrice = _overallPrice + 20;
            }
            if (_snowboard == true)
            {
                _overallPrice = _overallPrice + 25;
            }
            if (_helmet == true)
            {
                _overallPrice = _overallPrice + 10;
            }
            if (_accessories == true)
            {
                _overallPrice = _overallPrice + 15;
            }

            return 0;
        }


        private int GetAge()
        {
            return DateTime.Now.Year - _birthDate.Year;
        }

        public static string operator ==(Person p1, Person p2)
        {
            if (p1._pesel == p2._pesel)
            {
                return "PESEL-e są takie same";
            }
            else
                return "";
        }

        public static string operator !=(Person p1, Person p2)
        {
            if (p1._pesel != p2._pesel)
            {
                return "PESEL-e nie są takie same";
            }
            else
                return "";
        }
    }
}
