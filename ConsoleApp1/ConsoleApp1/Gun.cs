using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Gun
    {
        private string Name { get; set; }
        private float Caliber { get; set; }
        private double Range { get; set; }
        public Gun()
        {
        }
        public Gun(string _Name,float _Caliber, double _Range)
        {
            this.Name = _Name;
            this.Caliber = _Caliber;
            this.Range = _Range;
        }

    }
}
