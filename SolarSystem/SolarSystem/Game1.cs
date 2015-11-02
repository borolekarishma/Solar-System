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


namespace SolarSystem
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D backgroundimg, mercury, venus, earth, mars, jupiter, saturn, uranus, neptune, pluto, sun;
        int m1x, m1y, vx, vy, ex, ey, m2x, m2y, jx, jy, sx, sy, ux, uy, nx, ny, px, py, loop1, loop2, loop3, loop4, loop5, loop6, loop7, loop8, loop9, screen_w, screen_h ;
        double theta1, theta2, theta3, theta4, theta5, theta6, theta7, theta8, theta9;
        Vector2 m1,v,e,m2,j,s,u,n,p;
        
            
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.IsFullScreen = true;
            screen_w = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            screen_h = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            graphics.PreferredBackBufferWidth = screen_w;
            graphics.PreferredBackBufferHeight = screen_h;
            m1x = screen_w / 2 + 220;
            m1y = screen_h / 2 - 11;
            vx = screen_w / 2 + 260;
            vy = screen_h / 2 - 16;
            ex = screen_w / 2 + 310;
            ey = screen_h / 2 - 18;
            m2x = screen_w / 2 + 365;
            m2y = screen_h / 2 - 13;
            jx = screen_w / 2 + 410;
            jy = screen_h / 2 - 70;
            sx = screen_w / 2 + 580;
            sy = screen_h / 2 - 60;
            ux = screen_w / 2 + 755;
            uy = screen_h / 2 - 22;
            nx = screen_w / 2 + 820;
            ny = screen_h / 2 - 19;
            px = screen_w / 2 + 880;
            py = screen_h / 2 - 6;
            
            theta1 = 0;
            theta2 = 0;
            theta3 = 0;
            theta4 = 0;
            theta5 = 0;
            theta6 = 0;
            theta7 = 0;
            theta8 = 0;
            theta9 = 0;
            m1 = new Vector2(m1x, m1y);
            v = new Vector2(vx,vy);
            e = new Vector2(ex, ey);
            m2 = new Vector2(m2x, m2y);
            j = new Vector2(jx, jy);
            s = new Vector2(sx, sy);
            u = new Vector2(ux, uy);
            n = new Vector2(nx, ny);
            p = new Vector2(px, py);

            loop1 = 0;
            loop2 = 0;
            loop3 = 0;
            loop4 = 0;
            loop5 = 0;
            loop6 = 0;
            loop7 = 0;
            loop8 = 0;
            loop9 = 0;
            
            
            Content.RootDirectory = "Content";
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
            spriteBatch = new SpriteBatch(GraphicsDevice);
            backgroundimg = Content.Load<Texture2D>("stars");
            mercury = Content.Load<Texture2D>("mercury");
            venus= Content.Load<Texture2D>("venus");
            earth= Content.Load<Texture2D>("earth");
            mars= Content.Load<Texture2D>("Mars");
            jupiter= Content.Load<Texture2D>("jupiter");
            saturn= Content.Load<Texture2D>("saturn");
            uranus= Content.Load<Texture2D>("uranus");
            neptune= Content.Load<Texture2D>("neptune");
            pluto = Content.Load<Texture2D>("pluto");
            sun = Content.Load<Texture2D>("sun1");

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
            if (loop1 == 5)
            {
                theta1 = (theta1 > 360) ? 0 : (theta1 + 0.5); 
                m1x = screen_w / 2 + (int)(13000 * Math.Cos(theta1) * Math.PI / 180);
                m1y = screen_h / 2 + (int)(8000 * Math.Sin(theta1) * Math.PI / 180);
                m1.X = m1x;
                m1.Y = m1y;
                loop1 = 0;
            }
            else loop1++;

            if (loop2 == 5)
            {
                theta2 = (theta2 > 360) ? 0 : (theta2 + 0.08); 
                vx = screen_w / 2 + (int)(15000 * Math.Cos(theta2) * Math.PI / 180);
                vy = screen_h / 2 + (int)(10000 * Math.Sin(theta2) * Math.PI / 180);
                v.X = vx;
                v.Y = vy;
                loop2 = 0;
            }
            else loop2++;
            
           
            if (loop3 == 5)
            {
                theta3 = (theta3 > 360) ? 0 : (theta3 + 0.03); 
                ex = screen_w / 2 + (int)(18000 * Math.Cos(theta3) * Math.PI / 180);
                ey = screen_h / 2 + (int)(12000 * Math.Sin(theta3) * Math.PI / 180);
                e.X = ex;
                e.Y = ey;
                loop3 = 0;
            }
            else loop3++;
            
            if (loop4 == 5)
            {
                theta4 = (theta4 > 360) ? 0 : (theta4 + 0.01); 
                m2x = screen_w / 2 + (int)(20000 * Math.Cos(theta4) * Math.PI / 180);
                m2y = screen_h / 2 + (int)(14000 * Math.Sin(theta4) * Math.PI / 180);
                m2.X = m2x;
                m2.Y = m2y;
                loop4 = 0;
            }
            else loop4++;
            
            if (loop5 == 5)
            {
                theta5 = (theta5 > 360) ? 0 : (theta5 + 0.2); 
                jx = screen_w / 2 + (int)(26000 * Math.Cos(theta5) * Math.PI / 180);
                jy = screen_h / 2 + (int)(18000 * Math.Sin(theta5) * Math.PI / 180);
                j.X = jx-75;
                j.Y = jy-70;
                loop5 = 0;
            }
            else loop5++;
            
            if (loop6 == 5)
            {
                theta6 = (theta6 > 360) ? 0 : (theta6 + 0.06); 
                sx = screen_w / 2 + (int)(36000 * Math.Cos(theta6) * Math.PI / 180);
                sy = screen_h / 2 + (int)(24000 * Math.Sin(theta6) * Math.PI / 180);
                s.X = sx-75;
                s.Y = sy-60;
                loop6 = 0;
            }
            else loop6++;
            
            if (loop7 == 5)
            {
                theta7 = (theta7 > 360) ? 0 : (theta7 + 0.1); 
                ux = screen_w / 2 + (int)(42000 * Math.Cos(theta7) * Math.PI / 180);
                uy = screen_h / 2 + (int)(28000 * Math.Sin(theta7) * Math.PI / 180);
                u.X = ux;
                u.Y = uy;
                loop7 = 0;
            }
            else loop7++;
            
            if (loop8 == 5)
            {
                theta8 = (theta8 > 360) ? 0 : (theta8 + 0.08); 
                nx = screen_w / 2 + (int)(46000 * Math.Cos(theta8) * Math.PI / 180);
                ny = screen_h / 2 + (int)(31000 * Math.Sin(theta8) * Math.PI / 180);
                n.X = nx;
                n.Y = ny;
                loop8 = 0;
            }
            else loop8++;
            
            if (loop9 == 5)
            {
                theta9 = (theta9 > 360) ? 0 : (theta9 + 0.04); 
                px = screen_w / 2 + (int)(49000 * Math.Cos(theta9) * Math.PI / 180);
                py = screen_h / 2 + (int)(33000 * Math.Sin(theta9) * Math.PI / 180);
                p.X = px;
                p.Y = py;
                loop9 = 0;
            }
            else loop9++;
          
            
            base.Update(gameTime);
        }


        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(backgroundimg, new Rectangle(0, 0, screen_w, screen_h), Color.White);
            spriteBatch.Draw(sun, new Vector2(screen_w / 2 - 200, screen_h / 2 - 161), Color.White);
            spriteBatch.Draw(jupiter, j, Color.White);
            spriteBatch.Draw(mercury, m1, Color.White);
            spriteBatch.Draw(venus, v, Color.White);
            spriteBatch.Draw(earth, e, Color.White);
            spriteBatch.Draw(mars, m2, Color.White);
            spriteBatch.Draw(saturn, s, Color.White);
            spriteBatch.Draw(uranus, u, Color.White);
            spriteBatch.Draw(neptune, n, Color.White);
            spriteBatch.Draw(pluto, p, Color.White);
            




            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
