using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalProg
{
   abstract class Animal
    {
        
        string ras = "";
        static int count = 0;


        public Animal()
        {
            count++;
        }



        public abstract string Sound();
       

        public string Ras
        {
            get { return ras; }
        }
      
       public static int Count
        {
            get { return count; }
        }   
    
   }
}
