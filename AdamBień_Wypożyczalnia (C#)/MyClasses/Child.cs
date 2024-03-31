using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamBień_Wypożyczalnia.MyClasses
{
    public class Child : Person
    {
        private string _discount1;
        private string _discount2;
        private string _experience;
        private bool _protectors;
        private bool _instructor;
        private DateTime _borrowTime;
        private string _borrowTimeLenght;
        private int _priceDiscountK;
        private int _priceDiscountS;
        private int _price;
        private int _protectorsPrice;
        private int _instructorPrice;
        private int _borrowTimePrice;
        public int _overallPrice;

        public Child() : base()
        {
            _discount1 = "Nie";
            _discount2 = "Nie";
            _experience = "Tak";
            _protectors = false;
            _instructor = false;
            _borrowTime = DateTime.Now;
            _borrowTimeLenght = "-";
            _priceDiscountK = 0;
            _priceDiscountS = 0;
            _price = 0;
            _protectorsPrice = 0;
            _instructorPrice = 0;
            _borrowTimePrice = 0;
            _overallPrice = 0;
        }

        public Child(string firstName, string lastName, DateTime birthDate, string pesel, string gender, bool skis, 
            bool helmet, bool accessories, bool snowboard, string discount1, string discount2, string experience, bool protectors,
            bool instructor, DateTime borrowTime, string borrowTimeLenght, Bitmap picture) : 
            base(firstName, lastName, birthDate, pesel, gender, skis, helmet, accessories, snowboard, picture)
        {
            _discount1 = discount1;
            _discount2 = discount2;
            _experience = experience;
            _protectors = protectors;
            _instructor = instructor;
            _borrowTime = borrowTime;
            _borrowTimeLenght = borrowTimeLenght;
            _picture = picture;
        }

        public Child(Child c) : base(c)
        {
            _discount1 = c._discount1;
            _discount2 = c._discount2;
            _experience = c._experience;
            _protectors = c._protectors;
            _instructor = c._instructor;
            _borrowTime = c._borrowTime;
            _borrowTimeLenght = c._borrowTimeLenght;
            _priceDiscountK = c._priceDiscountK;
            _priceDiscountS = c._priceDiscountS;
            _picture = c._picture;
        }

        public override List<string> GetInfo()
        {
            List<string> cinfo = base.GetInfo();
            cinfo.Add("Zniżka przedszkolna:\t\t " + _discount1);
            cinfo.Add("Zniżka szkolna:\t\t\t " + _discount2);
            cinfo.Add("Doświadczenie w narciarstwie:\t " + _experience);
            cinfo.Add("Ochraniacze dla dzieci:\t\t " + (_protectors ? "Tak" : "Nie"));
            cinfo.Add("Wypożyczenie instruktora:\t\t " + (_instructor ? "Tak" : "Nie"));
            cinfo.Add("Data wypożyczenia:\t\t " + _borrowTime);
            cinfo.Add("Długość wypożyczenia:\t\t " + _borrowTimeLenght);
            cinfo.Add("Koszt wypożyczenia:\t\t " + GetPrice() + "zł");

            return cinfo;
        }

        public int GetPrice()
        {
            _overallPrice = base._overallPrice;
            _price = base._price;

            if (_protectors == true)
            {
                _protectorsPrice = 10;
            }
            if (_instructor == true)
            {
                _instructorPrice = 20;
            }
            if (_borrowTimeLenght == "30 min")
            {
                _borrowTimePrice = 10;
            }
            if (_borrowTimeLenght == "1 h")
            {
                _borrowTimePrice = 20;
            }
            if (_borrowTimeLenght == "1,5 h")
            {
                _borrowTimePrice = 30;
            }
            if (_borrowTimeLenght == "2 h")
            {
                _borrowTimePrice = 40;
            }

            GetDiscountK();
            GetDiscountS();

            _price = _price + _protectorsPrice + _instructorPrice + _borrowTimePrice + _priceDiscountK + _priceDiscountS;

            _overallPrice = _overallPrice + _price;

            if (_price < 0)
            {
                _price = 0;
            }
            return _price;
        }

        private int GetDiscountK()
        {
            if (_discount1 == "Tak")
            {
                _priceDiscountK = 15;
            }

            return 0;
        }

        private int GetDiscountS()
        {
            if (_discount2 == "Tak")
            {
                _priceDiscountS = 10;
            }

            return 0;
        }
    }
}