using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalProg
{
    class Dog: Animal
    {
        string name;

        public Dog(string name)
        {
            this.name = name;
        }
        public override string Sound()
        {
            return "Vov";
        }
    
    
    }
}
