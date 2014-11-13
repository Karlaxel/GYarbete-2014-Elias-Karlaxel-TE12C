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
        public float hastighet;
        
        public string info;
        public int ålder;
        public double vinkelPåKast;
        public Texture2D texturFörPerson;
        public int posx;
        public int posy;


        public Personer(float h, string i, int å, double v, Texture2D T, int x, int y)
        {
            hastighet = h;
            info = i;
            ålder = å;
            vinkelPåKast = v;
            texturFörPerson = T;
            posx = x;
            posy = y;
        }
       
        
    }
}
