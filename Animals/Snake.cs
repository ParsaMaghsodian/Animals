using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Snake : Animals
    {
        
        public override string Eat()
        {
            return "This " + NameOfAmimal + " Eat " + Food;
        }

        public override string Howmove()
        {
            return "This " + NameOfAmimal + " " + Move;
        }

        public override string MakeSound()
        {
            return "This " + NameOfAmimal + " " + Sound;
        }

        public override int NumbersOfFoot()
        {
            return  0;
        }
    }
}
