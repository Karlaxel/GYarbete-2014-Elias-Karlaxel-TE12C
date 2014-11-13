using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;



namespace gyarbete2014KarlaxelElias
{
    class fotboll
    {
         class Basketboll
    {
        public double viktBasketboll = 0.623689509;
        public double radie = 7.0358;
        // källor där varibarna till det här föremålet kommer ifrån http://www.answers.com/Q/What_is_the_diameter_or_radius_of_a_basketball

        public int basketBollPositionX;
        public int basketbollpositiony;
        public Texture2D texturFörBasketBoll;
        public Vector2 posB = new Vector2(100,50);
   
        public Basketboll(Vector2 b, Texture2D T)
        {

            posB = b;
            texturFörBasketBoll = T;

        }
        
       
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texturFörBasketBoll,posB, Color.White);
        }

     

    }
}
    }
}
