
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uppgift77
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv ditt första tal");
            double tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ditt andra tal");
            double tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ditt trejde tal");
            double tal3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ditt fjärde tal");
            double tal4 = int.Parse(Console.ReadLine());
            double m = medelvärde(tal1, tal2, tal3, tal4);
            double mtal = minsta(tal1, tal2, tal3, tal4);
            double stal = största(tal1, tal2, tal3, tal4);
            
            Console.WriteLine("Minstal"+ "" + mtal);
            Console.WriteLine("största tal" + ""  + stal);
            Console.WriteLine(m + "" + "medelväde");
            Console.ReadLine();
        }
          
            
            
            public static double medelvärde(double x1 , double x2, double x3, double x4)
            {
             double medelvärde = (x1 + x2 +x3 + x4)/4;
             return medelvärde;
            }

            public static double minsta(double x1, double x2, double x3, double x4)
            {
                double minstatal;
                if (x1 < x2 && x1 < x3 && x1 < x4)
                {
                    minstatal = x1;
                    return minstatal;
                }

                else if (x2 < x1 && x2 < x3 && x2 < x4)
                {
                    minstatal = x2;
                    return minstatal;
                }

                else if (x3 < x1 && x3 < x2 && x3 < x4)
                {
                    minstatal = x3;
                    return minstatal;
                }

                else
                {
                    minstatal = x4;
                    return minstatal;
                }

            }

            public static double största(double x1, double x2, double x3, double x4)
            {
                double störstatal;
                if (x1 > x2 && x1 > x3 && x1 > x4)
                {
                    störstatal = x1;
                    return störstatal;
                }

                else if (x2 > x1 && x2 > x3 && x2 > x4)
                {
                    störstatal = x2;
                    return störstatal;
                }

                else if (x3 > x1 && x3 > x2 && x3 > x4)
                {
                    störstatal = x3;
                    return störstatal;
                }

                else
                {
                    störstatal = x4;
                    return störstatal;
                }
            }
    
    }
 }

