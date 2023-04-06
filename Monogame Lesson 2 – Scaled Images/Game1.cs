using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Lesson_2___Scaled_Images
{
    public class Game1 : Game
    {
        Texture2D rectangleTexture;
        Texture2D circleTexture;
        Rectangle rectangleRect;
        Rectangle rectangleRect2;
        Rectangle rectangleRect3;
        Rectangle circleRect;
        Rectangle circleRect2;      
        private SpriteFont font;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();

            circleRect = new Rectangle(200, 350, 100, 100);
            circleRect2 = new Rectangle(500, 350, 100, 100);
            rectangleRect = new Rectangle(100, 300, 600, 100);
            rectangleRect2 = new Rectangle(200, 200, 350, 100);
            rectangleRect3 = new Rectangle(400, 210, 140, 80);

            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            font = Content.Load<SpriteFont>("Text");

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
            GraphicsDevice.Clear(Color.Bisque);

            _spriteBatch.Begin();
            _spriteBatch.Draw(rectangleTexture, rectangleRect, Color.DarkSlateGray);
            _spriteBatch.Draw(rectangleTexture, rectangleRect2, Color.DarkSlateGray);
            _spriteBatch.Draw(rectangleTexture, rectangleRect3, Color.LightBlue);
            _spriteBatch.Draw(circleTexture, circleRect, Color.Black);
            _spriteBatch.Draw(circleTexture, circleRect2, Color.Black);
            _spriteBatch.DrawString(font, "Delorean", new Vector2(140, 310), Color.Black);
            _spriteBatch.End();

            base.Draw(gameTime);
        }




    }
}