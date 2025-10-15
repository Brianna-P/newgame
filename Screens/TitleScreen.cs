using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using newgame.Core;

namespace newgame.Screens;

    public class TitleScreen : Screen
    {
        private SpriteFont _font;

        public override void LoadContent()
        {
            _font = Game1.Instance.Content.Load<SpriteFont>("DefaultFont");
        }

        public override void Update(GameTime gameTime)
        {
            // press Enter to go to MainMenuScreen
            if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Enter))
            {
                ScreenManager.ChangeScreen(new MainMenuScreen());
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(_font, "Press Enter to Start", new Vector2(100, 100), Color.White);
        }
    }

