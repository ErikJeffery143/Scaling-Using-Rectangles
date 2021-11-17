using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Scaling_Using_Rectangles
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D rectTexture;
        Rectangle rectRectangle;

        Texture2D palmTexture;

        Texture2D circleTexture;
        Rectangle circleRectangle;

        SpriteFont textfont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            rectRectangle = new Rectangle(10, 3, 50, 50);
            circleRectangle = new Rectangle(10, 100, 50, 50);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            rectTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            palmTexture = Content.Load<Texture2D>("Palm");

            textfont = Content.Load<SpriteFont>("textfont");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MidnightBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(circleTexture, new Rectangle(100,175,600,600), Color.HotPink);
            _spriteBatch.Draw(rectTexture, new Rectangle(1, 285, 800, 7), Color.MidnightBlue);
            _spriteBatch.Draw(rectTexture, new Rectangle(1, 320, 800, 10), Color.MidnightBlue);
            _spriteBatch.Draw(rectTexture, new Rectangle(1, 355, 800, 13), Color.MidnightBlue);
            _spriteBatch.Draw(rectTexture, new Rectangle(1, 390, 800, 16), Color.MidnightBlue);
            _spriteBatch.Draw(rectTexture, new Rectangle(1, 425, 800, 19), Color.MidnightBlue);
            _spriteBatch.Draw(rectTexture, new Rectangle(1, 460, 800, 22), Color.MidnightBlue);
            _spriteBatch.Draw(palmTexture, new Vector2(400, 150), Color.Black);
            _spriteBatch.DrawString(textfont, "Neon Sunset", new Vector2(400,150), Color.White);
            //_spriteBatch.Draw(circleTexture, new Rectangle())
            //NEON SUNSET
             

            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
