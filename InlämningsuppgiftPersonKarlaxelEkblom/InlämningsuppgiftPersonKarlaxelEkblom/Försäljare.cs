using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InlämningsuppgiftPersonKarlaxelEkblom
{
    class Försäljare:Anställd
    {
        protected double provsion;

        public Försäljare() { }

        public Försäljare(string namn, string ort, double lön, double provision)
        {
         this.namn = namn;
         this.ort = ort;
         this.lön = lön;
         this.provsion = provision;
        }
        public string Fakta() { return "Namn" + namn + "Ort" + ort + "Lön" + lön + "Provision" + provsion; }
    }
}
