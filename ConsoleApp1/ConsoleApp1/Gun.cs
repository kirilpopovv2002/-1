using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Gun
    {
        private string _Name { get; set; }
        private double _Caliber { get; set; }
        private double _Range { get; set; }
        public Gun()
        {
            this._Name = "Now name";
            this._Caliber = 0;
            this._Range = 0;
        }
        public Gun(string _name, double _caliber, double _range)
        {
            this._Name = _name;
            this._Caliber = _caliber;
            this._Range = _range;
        }
        public string NameEdit(string _name)
        {
            this._Name = _name;
            return _name;
        }
        public double CaliberEdit(double _caliber)
        {
            this._Caliber = _caliber;
            return _caliber;
        }
        public double RangeEdit(double _range)
        {
            this._Range = _range;
            return _range;
        }

        public string NameInfo()
        {
            
            return this._Name;
        }
        public double CaliberInfo()
        {
            
            return this._Caliber;
        }
        public double RangeInfo()
        {
            
            return this._Range;
        }
        public override string ToString()
        {
            return string.Format("Название:{0}\nКалибр:{1}\nДальность:{2}",this._Name,this._Caliber,this._Range);
        }
    }
}
