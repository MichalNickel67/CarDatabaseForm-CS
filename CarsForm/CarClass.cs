using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars1
{
    internal class CarClass
    {
        private string brand;
        private string model;
        private int year;
        private decimal enginesize;
        private string fueltype;

        public CarClass(string b, string m, int y, decimal e, string f)
        {
            brand = b;
            model = m;
            year = y;
            enginesize = e;
            fueltype = f;
        }

        public string Brand { get { return brand; } }
        public string Model { get { return model; } }
        public int Year { get { return year; } }
        public decimal Enginesize { get { return enginesize; } }
        public string Fueltype { get { return fueltype; } }
    }
}