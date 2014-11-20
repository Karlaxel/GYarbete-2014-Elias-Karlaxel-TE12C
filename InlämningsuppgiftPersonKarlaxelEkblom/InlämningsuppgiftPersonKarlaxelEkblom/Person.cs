using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InlämningsuppgiftPersonKarlaxelEkblom
{
    class Person
    {
        static int count = 0;
        protected string namn;
        protected string ort;
        public Person() { count++; }

        public Person(string namn, string ort)
        {
            this.namn = namn;
            this.ort = ort;
            count++;

        }
        public string Fakta() { return "Namn;" + namn + "Ort" + ort + count; }
    }
}
