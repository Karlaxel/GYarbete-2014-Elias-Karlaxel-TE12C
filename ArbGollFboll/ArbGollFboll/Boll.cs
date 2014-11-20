using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArbGollFboll
{
    class Boll
    {
        protected int diameter;
        protected string matrieal;
        protected  string färg;
        public static count;

    
        public Boll() {}
        
       public Boll(int diameter, string matrieal, string färg)
            {
            this.diameter = diameter;
            this.matrieal = matrieal;
            this.färg = färg;
             count++;
            }
       
        public int Diameter
        {
            get ( return diameter;)
            set (set diameter = Value;
        }
        
        public int Rulla(int antal);{
        return 10;
        
       
      
            public double Volym()   
             {
             double radie = diameter/2.0;
             return Math.PI * 4 * radie * radie * radie / 3;
             }
        


        
}
}
 
// två typer av medlemsvariabler en instansvaribler och en medlamsvaribaler instans är unika för varje objekt medans medlemsvaribler påverkar alla 

