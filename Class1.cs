using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisokDemo1
{
    public class Sandwhich
    {
        private string _bltName = "BLT";
        private decimal _bltPrice = 1.50m;

        private string _hamName = "Ham";
        private decimal _hamPrice = 4.54m;

        private string _cheesePestoName = "Cheese & Pesto";
        private decimal _cheesePestoPrice = 7.54m;

        private string _tunaName = "Tuna";
        private decimal _tunaPrice = 1.90m;

        private string _cheeseName = "Cheese";
        private decimal _cheesePrice = 0.70m;

        private string _lettuceName = "Lettuce";
        private decimal _lettucePrice = 0.90m;

        private string _tomatoName = "Tomato";
        private decimal _tomatoPrice = 0.50m;

        private string _butterName = "Butter";
        private decimal _butterPrice = 0.30m;


        public string BLTName
        {
            get { return _bltName; }
        }
        public decimal BLTPrice
        {
            get { return _bltPrice; }
        }

        public string HamName
        {
            get { return _hamName; }
        }
        public decimal HamPrice
        {
            get { return _hamPrice; }
        }

        public string CheesePestoName
        {
            get { return _cheesePestoName; }
        }
        public decimal CheesePestoPrice
        {
            get { return _cheesePestoPrice; }
        }

        public string TunaName
        {
            get { return _tunaName; }
        }
        public decimal TunaPrice
        {
            get { return _tunaPrice; }
        }

        public string CheeseName
        {
            get { return _cheeseName; }
        }
        public decimal CheesePrice
        {
            get { return _cheesePrice; }
        }

        public string LettuceName
        {
            get { return _lettuceName; }
        }

        public decimal LettucePrice
        {
            get { return _lettucePrice; }
        }

        public string TomatoName
        {
            get { return _tomatoName; }
        }
        public decimal TomatoPrice
        {
            get { return _tomatoPrice; }
        }

        public string ButterName
        {
            get { return _butterName; }
        }
        public decimal ButterPrice
        {
            get { return _butterPrice; }
        }

    }

}