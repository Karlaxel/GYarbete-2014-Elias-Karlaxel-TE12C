using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace GYArbete2014KarlaxelEliasTE12C
{
    class Personer
    {
        public double kraft;
        public double maxKraft;
        public string info;
        public int ålder;
        public double vinkelPåKast;
        public Texture2D texturFörPerson;


        public Personer(double k, double mk, string i, int å, double v, Texture2D T)
        {
            kraft = k;
            maxKraft = mk;
            info = i;
            ålder = å;
            vinkelPåKast = v;
            texturFörPerson = T;
        }
       
        
    }
}
