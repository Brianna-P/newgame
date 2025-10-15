using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using newgame.Core;
namespace newgame.Screens;


    public class MainMenuScreen : Screen
    {
        private SpriteFont _font;

        public override void LoadContent()
        {
            _font = Game1.Instance.Content.Load<SpriteFont>("File");
        }

        public override void Update(GameTime gameTime)
        {
            // Example: press Escape to go back to StartScreen

                        if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Escape))
            {
                ScreenManager.ChangeScreen(new TitleScreen());
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(_font, "Welcome To Main Menu! Press Escape to return To TitleScreen. ", new Vector2(100, 100), Color.White);

        }
    }

