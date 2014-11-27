using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumantalkKarlaxelEkblomTE12C
{
    class English:Human
    {

        public English(string namn)
        {
            this.namn = namn;
        }

        public string Talk()
        {
            return "hello how are you"; 
        }
    }
}
