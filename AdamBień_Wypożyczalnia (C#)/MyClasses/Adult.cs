using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamBień_Wypożyczalnia.MyClasses
{
    public class Adult : Person
    {
        private string _discount; //zniżka emerycka
        private string _children; //czy posiada dzieci
        private decimal _childrenNo; //liczba dzieci
        private DateTime _borrowTime; //kiedy wypożyczono
        private string _borrowTimeLenght; //czas wypożyczenia (jak długo)
        private int _priceDiscountS;
        private int _priceDiscountC;
        private int _price;
        private Bitmap _picture;
        private int _borrowTimePrice;
        public List<string> _size = new List<string>();



        public Adult() : base()
        {
            _discount = "Nie";
            _children = "Nie";
            _childrenNo = 0;
            _borrowTime = DateTime.Now;
            _borrowTimeLenght = "-";
            _priceDiscountS = 0;
            _priceDiscountC = 0;
            _price = 0;
            _picture = new Bitmap(@"iamge1.jpg", true);
            _size = new List<string>();
            _borrowTimePrice = 0;
        }

        public Adult(string firstName, string lastName, DateTime birthDate, string pesel, string gender, bool skis, 
            bool helmet, bool accessories, bool snowboard, string discount, string children, decimal childrenNo, DateTime borrowTime,
            string borrowTimeLenght, Bitmap picture, List<string> size) : 
            base(firstName, lastName, birthDate, pesel, gender, skis, helmet, accessories, snowboard, picture)
        {
            _discount = discount;
            _children = children;
            _childrenNo = childrenNo;
            _borrowTime = borrowTime;
            _borrowTimeLenght = borrowTimeLenght;
            _picture = picture;
            _size = size;
        }

        public Adult(Adult a) : base(a)
        {
            _discount = a._discount;
            _children = a._children;
            _childrenNo = a._childrenNo;
            _borrowTime = a._borrowTime;
            _borrowTimeLenght = a._borrowTimeLenght;
            _priceDiscountS = a._priceDiscountS;
            _priceDiscountC= a._priceDiscountC;
            _picture = a._picture;
            _size = a._size;
            _borrowTime = a._borrowTime;
        }

        public override List<string> GetInfo()
        {
            List<string> ainfo = base.GetInfo();
            ainfo.Add("Zniżka seniora:\t\t\t " + _discount);
            ainfo.Add("Posiada dzieci:\t\t\t " + _children);
            ainfo.Add("Liczba dzieci:\t\t\t " + _childrenNo);
            ainfo.Add("Data wypożyczenia:\t\t " + _borrowTime);
            ainfo.Add("Długość wypożyczenia:\t\t " + _borrowTimeLenght);
            ainfo.Add("Koszt wypożyczenia:\t\t " + GetPrice() + "zł");
            ainfo.Add("Wypożyczone rozmiary butów: \t");
            foreach (var item in _size)
            {
                ainfo.Add(item.ToString());
            }

            return ainfo;
        }

        public void AddSize(string size)
        {
            _size.Add(size);
        }

        public int GetPrice()
        {
            _price = base._price;

            if (_borrowTimeLenght == "30 min")
            {
                _borrowTimePrice = 20;
            }
            if (_borrowTimeLenght == "1 h")
            {
                _borrowTimePrice = 35;
            }
            if (_borrowTimeLenght == "1,5 h")
            {
                _borrowTimePrice = 50;
            }
            if (_borrowTimeLenght == "2 h")
            {
                _borrowTimePrice = 65;
            }

            GetDiscountS();
            GetDiscountC();

            _price = _price + _borrowTimePrice + _priceDiscountS + _priceDiscountC;

            if (_price < 0)
            {
                _price = 0;
            }

            return _price;
        }

        private int GetDiscountS()
        {
            if (_discount == "Tak")
            {
                _priceDiscountS = 15;
            }

            return 0;
        }

        private int GetDiscountC()
        {
            if (_children == "Tak")
            {
                _priceDiscountC = 10;
            }

            return 0;
        }
    }
}
