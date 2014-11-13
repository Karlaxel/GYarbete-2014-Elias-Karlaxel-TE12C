﻿using System;
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
       // Point skullballFrameSize = new Point(75, 75);
       
        // texturer
        Texture2D basketboll;
        Texture2D texturFörPerson;
        Basketboll boll;
        public Vector2 posB = new Vector2(0, 650);
        float tid = 0;
        Personer person;
        double vinkel;

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
            person = new Personer(75,"",18,45,Content.Load<Texture2D>("persontest") ,1,1);
            spriteBatch = new SpriteBatch(GraphicsDevice); 
            basketboll = Content.Load<Texture2D>("gytest");
            boll = new Basketboll(posB, basketboll);
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
            tid += 0.1666667f;
            // TODO: Add your update logic here
            boll.posB.X = person.hastighet * tid;
            vinkel = Math.Sin(person.vinkelPåKast);
            
            boll.posB.Y = (float)(650f - person.hastighet * vinkel * tid + 0.5f * 9.82f * tid * tid);


            

            if (boll.posB.Y > 700f)
            {
                boll.posB.Y = 650f;
                boll.posB.X = 0;
            }

            
            
            KeyboardState KeyboardState = Keyboard.GetState();
            if (boll.posB.X == 0)
            {
                if (KeyboardState.IsKeyDown(Keys.Left))
                    person.hastighet -= 1;
                if (KeyboardState.IsKeyDown(Keys.Right))
                    person.hastighet += 1;
                if (KeyboardState.IsKeyDown(Keys.Up))
                    person.vinkelPåKast += 1;
                if (KeyboardState.IsKeyDown(Keys.Down))
                    person.vinkelPåKast -= 1;
            }

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
            spriteBatch.Begin();
            boll.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
   
    
    
    }
}
