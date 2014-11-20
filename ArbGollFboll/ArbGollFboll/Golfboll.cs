using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArbGollFboll
{
    class Golfboll:Boll
    {
        private string fabrikat;
        public Golfboll(int diamateter, string matrial, string färg, string fabrikat)
        {
            this.diameter = diamateter;
            this.matrieal = matrieal;
            this.färg = färg;
            this.fabrikat = fabrikat;

        }
        public override int Rulla(int antal)
        {
            return base.Rulla(3) + 10;

        }
        public bool Godkänd()
        {

            return base.diameter == 43;
        }
    
    }
}
