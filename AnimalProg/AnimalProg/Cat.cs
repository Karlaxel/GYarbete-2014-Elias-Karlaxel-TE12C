using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalProg
{
    class Cat: Animal, ILandBound
    {
        string name;

        public Cat(string name) { this.name = name; }

        public override string Sound()
        {
            return "Mjau";
        }

        public int NumberOfLegs()
        {
            return 4;
        }
    
    
    }
}
