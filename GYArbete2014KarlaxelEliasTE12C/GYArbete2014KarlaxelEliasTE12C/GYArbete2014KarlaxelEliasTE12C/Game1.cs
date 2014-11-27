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
    /// <summary>
    /// This is the main type for your game 
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
       
       
        // texturer
        Texture2D basketboll;
        Texture2D texturFörPerson;
        Basketboll boll;
        Texture2D Bakgrund;
        Texture2D textuförbasketlinjefunktion;
        
        public Vector2 posB = new Vector2(40, 650);
        float tid = 0;
        Personer person;
        double vinkel1;
        double vinkel2;
        int tidmätare = 1;
        // spritefonts variabler
        SpriteFont Fysikformel;
        SpriteFont Xposition;
        SpriteFont Yposition;
        SpriteFont info;
        public int counter = 0;
        int sekunder = 0;
       

        //postioner för spritefronts 
        Vector2 FysikformelPos;
        Vector2 XpositionPos;
        Vector2 YpositionPos;
        Vector2 BakgroundPos;
        Vector2 infoPos;
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 700;
            graphics.PreferredBackBufferWidth = 1400;

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
             
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
        
            
            // Create a new SpriteBatch, which can be used to draw textures.
            // person blir instanserad
            person = new Personer(75,"",18,Math.PI/4,Content.Load<Texture2D>("persontest") ,1,1);
            
            spriteBatch = new SpriteBatch(GraphicsDevice); 
           
            // boll blir instanserad
            textuförbasketlinjefunktion = Content.Load<Texture2D>("basketballAndragradare");
            basketboll = Content.Load<Texture2D>("basketball");
            boll = new Basketboll(posB, basketboll);
           
            // spritefont blir instanserade 
            Fysikformel = Content.Load<SpriteFont>("Fysikformelfont");
            FysikformelPos.X = 275;
            FysikformelPos.Y = 650;
              
            Xposition = Content.Load<SpriteFont>("Xposition");
            XpositionPos.X = 900;
            XpositionPos.Y = 50;

            Yposition = Content.Load<SpriteFont>("Yposition");
            YpositionPos.X = 900;
            YpositionPos.Y = 100;

            info = Content.Load<SpriteFont>("info");
            infoPos.X = 50;
            infoPos.Y = 50;
            // TODO: use this.Content to load your game content here
            
            //texturer blir deklarade 
            Bakgrund = Content.Load<Texture2D>("background");
            BakgroundPos.X = 0;
            BakgroundPos.Y = 0;
        }


        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
           
            // TODO: Add your update logic here
            
            vinkel1 = Math.Sin(person.vinkelPåKast);
            vinkel2 = Math.Cos(person.vinkelPåKast);

            KeyboardState KeyboardState = Keyboard.GetState();

            if (KeyboardState.IsKeyDown(Keys.Enter))
                counter += counter + 1;
            if (counter > 20)
            {
                counter = 5;  
            }

            if (KeyboardState.IsKeyDown(Keys.Space))
            {
                boll.posB.X = 40;
                boll.posB.Y = 650;
                tid = 0;
                counter = 0;
            }

            if (counter % 2 == 1 && boll.posB.Y <= 650f && boll.posB.X < 1370f && boll.posB.Y > 0)
            {
                boll.posB.Y = (float)(650f - person.hastighet * vinkel1 * tid + 0.5f * 9.82f * tid * tid);
                
                boll.posB.X = (float)(40 + person.hastighet * vinkel2 * tid);
                tid += 0.01666667f * 3;
                
            }

            
                if (person.vinkelPåKast < 0)
                    person.vinkelPåKast = 0;
                else if (person.vinkelPåKast > Math.PI / 2)
                    person.vinkelPåKast = Math.PI / 2;
                if (person.hastighet < 0)
                    person.hastighet = 0;
                else if (person.hastighet > 125)
                    person.hastighet = 125;

            
             
            
            
           
            if (boll.posB.X == 40 && boll.posB.Y == 650)
            {
                if (KeyboardState.IsKeyDown(Keys.Left))
                    person.hastighet -= 1;
                if (KeyboardState.IsKeyDown(Keys.Right))
                    person.hastighet += 1;
                if (KeyboardState.IsKeyDown(Keys.Up))
                    person.vinkelPåKast += Math.PI / 180;
                if (KeyboardState.IsKeyDown(Keys.Down))
                    person.vinkelPåKast -= Math.PI / 180;
            }

            sekunder = Convert.ToInt32(tid);

            // ritar ut fonts 
           // spriteBatch.DrawString(Fysikformel,"hej", FysikformelPos, Color.Green);
            //person.vinkelPåKast.ToString()
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here


            // ritar ut fonts 
            //spriteBatch.DrawString(Fysikformel, "hej", FysikformelPos, Color.Green);
            //person.vinkelPåKast.ToString()
            
      

            
            spriteBatch.Begin();
           
            int hastighetdisplay = Convert.ToInt32(person.hastighet);
            int bollX = Convert.ToInt32(boll.posB.X - 40);
            int bollY = Convert.ToInt32(650 - boll.posB.Y);
            int vinkeldisplay = Convert.ToInt32(person.vinkelPåKast * 180 / Math.PI);

            if (1 == 1)
            {
                spriteBatch.Draw(textuförbasketlinjefunktion, posB, Color.White);
                tidmätare++;
            }
            
            spriteBatch.Draw(Bakgrund, BakgroundPos, Color.White);
            spriteBatch.DrawString(Fysikformel, "Height in Meters = " + hastighetdisplay + " m/s" + " * " + "sin (" + vinkeldisplay.ToString() + " degrees) -" + " 1/2 * 9.82 " + "* " + sekunder.ToString() + "s" + " * " + sekunder.ToString() + "s" + " (3 x Speed)", FysikformelPos, Color.Black);
            spriteBatch.DrawString(Xposition, "X Position For Basketboll in Meters = " + bollX, XpositionPos, Color.Black);
            spriteBatch.DrawString(Yposition, "Y position For Basketboll in Meters = " + bollY, YpositionPos,  Color.Black);
            spriteBatch.DrawString(info, "Press Enter to start and space to Restart", infoPos, Color.Black);
            boll.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
   
    
    
    }
}
