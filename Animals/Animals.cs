using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animals
    {
        public int Feet { get; set; }
        public string NameOfAmimal { get; set; }
        public string Color { get; set; }
        public string Food { get; set; }
        public string Sound { get; set; }
        public string Move { get; set; }
        public abstract string Howmove();
        public abstract string Eat();
        public abstract string MakeSound();
        public abstract int NumbersOfFoot();
    }
}
