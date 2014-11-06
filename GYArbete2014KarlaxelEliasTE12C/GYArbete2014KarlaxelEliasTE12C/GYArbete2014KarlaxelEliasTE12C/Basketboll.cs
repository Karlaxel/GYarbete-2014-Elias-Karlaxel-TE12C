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
    class Basketboll
    {
        public double viktBasketboll = 0.623689509;
        public double radie = 7.0358;
        // källor där varibarna till det här föremålet kommer ifrån http://www.answers.com/Q/What_is_the_diameter_or_radius_of_a_basketball

        public Vector2 basketBollPosition;
      
        public Texture2D texturFörBasketBoll;
   
        public Basketboll(Vector2 b, Texture2D T)
        {

            basketBollPosition = b;
            texturFörBasketBoll = T;

        }
        
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texturFörBasketBoll, basketBollPosition, Color.White);
        }



    }
}
