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
    class Tennisboll
    {
        public double viktTennisboll = 0.057;
        public double radie = 3.25;
        // källor där varibarna till det här föremålet kommer ifrån http://hypertextbook.com/facts/2000/ShefiuAzeez.shtml
        public int tennisBollPositionX;
        public int tennisBollPositionY;
        public Texture2D texturFörTennisBoll;



        public Tennisboll(int posX, int posY,Texture2D T)
        {
            tennisBollPositionX = posX;
            tennisBollPositionY = posY;
            texturFörTennisBoll = T;
        }
    }
}
