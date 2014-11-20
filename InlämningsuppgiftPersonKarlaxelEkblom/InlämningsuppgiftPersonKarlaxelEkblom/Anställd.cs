using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InlämningsuppgiftPersonKarlaxelEkblom
{
    class Anställd:Person
    {
        protected double lön;
        

        public Anställd() { }

        public Anställd(string namn, string ort, double lön)
        {
            this.namn = namn;
            this.ort = ort;
            this.lön = lön;
            
            
        }
        public string  Fakta() { return "Namn" + namn + "Ort" + ort + "Lön" + lön; }
        
    }
}
