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
        
        public Vector2 posB = new Vector2(0, 650);
        float tid = 0;
        Personer person;
        double vinkel1;
        double vinkel2;
       
        // spritefonts variabler
        SpriteFont Fysikformel;
        SpriteFont Xposition;
        SpriteFont Yposition;
        
        public int counter;
        int sekunder = 0;
       

        //postioner för spritefronts 
        Vector2 FysikformelPos;
        Vector2 XpositionPos;
        Vector2 YpositionPos;



        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 800;
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
            basketboll = Content.Load<Texture2D>("gytest");
            boll = new Basketboll(posB, basketboll);
           
            // spritefont blir instanserade 
            Fysikformel = Content.Load<SpriteFont>("Fysikformelfont");
            FysikformelPos.X = 450;
            FysikformelPos.Y = 700;
            
            Xposition = Content.Load<SpriteFont>("Xposition");
            XpositionPos.X = 850;
            XpositionPos.Y = 650;

            Yposition = Content.Load<SpriteFont>("Yposition");
            YpositionPos.X = 850;
            YpositionPos.Y = 700;
            // TODO: use this.Content to load your game content here
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
               
            
            
            if (counter % 2 == 1)
            {
                boll.posB.Y = (float)(650f - person.hastighet * vinkel1 * tid + 0.5f * 9.82f * tid * tid);
                
                boll.posB.X = (float)(person.hastighet * vinkel2 * tid);
                tid += 0.01666667f * 3;
                
            }

            
                if (person.vinkelPåKast < 0)
                    person.vinkelPåKast = 0;
                else if (person.vinkelPåKast > Math.PI / 2)
                    person.vinkelPåKast = Math.PI / 2;
            


            if (boll.posB.Y > 700f || boll.posB.X > 1300f)
            {
                boll.posB.Y = 650f;
                boll.posB.X = 0;
                counter = 0;
            }

            
            
           
            if (boll.posB.X == 0)
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

            sekunder = Convert.ToInt32(tid) / 3;

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
            boll.Draw(spriteBatch);
            int hastighetdisplay = Convert.ToInt32(person.hastighet / 3);
            
            spriteBatch.DrawString(Fysikformel, "Height = " + hastighetdisplay + " * " + "sin " + (person.vinkelPåKast * 180 / Math.PI).ToString() + " -" + " 0,50 * 9.82 " + "* " + sekunder.ToString() + " * " + sekunder.ToString(), FysikformelPos, Color.Black);
            spriteBatch.DrawString(Xposition, "X position for basketbollen" + boll.posB.X, XpositionPos, Color.Green);
            spriteBatch.DrawString(Yposition, "Y position For Basketboll" + "" + boll.posB.Y / 100, YpositionPos,  Color.Green);
            
            
            spriteBatch.End();

            base.Draw(gameTime);
        }
   
    
    
    }
}
