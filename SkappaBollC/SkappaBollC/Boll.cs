using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkappaBollC
{
    class Boll
    {
        public int radie;
        public string färg;
        public string matrierial;
        public static double Pi = 3.14;
        public static int count = 0;
      
        public void Boll()
        {
            count++;
        }


        public void Flytta()
        {

        }

        public double Area()
        {

            return radie * radie * pi;
        }

    }
}
