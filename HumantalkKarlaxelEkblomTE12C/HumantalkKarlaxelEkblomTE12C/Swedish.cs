using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumantalkKarlaxelEkblomTE12C
{
    class Swedish:Human
    {
        public Swedish(string namn)
        {
            this.namn = namn;
        }

        public string talk()
        {
            return "Hej Hur mår du?";
        }


    
    }
}
