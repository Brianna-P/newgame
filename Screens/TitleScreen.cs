using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using newgame.Core;

namespace newgame.Screens;

    public class TitleScreen : Screen
    {
        private SpriteFont _font;
        private Texture2D boxTexture;
        private Rectangle[] Rectangles = {
            new Rectangle(Game1.Instance.width/2 - 200, Game1.Instance.height/2 - 75, 400, 100),
            new Rectangle(Game1.Instance.width/2 - 200, Game1.Instance.height/2 + 75, 400, 100),
        };
        private string[] menuLabels = {
            "Start Game",
            "Quit"
        };

        public override void LoadContent()
        {
            _font = Game1.Instance.Content.Load<SpriteFont>("File");
            boxTexture = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            boxTexture.SetData(new[] { Color.White });
        }

        public override void Update(GameTime gameTime)
        {
            // press Enter to go to MainMenuScreen
            if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Enter))
            {
                ScreenManager.ChangeScreen(new MainMenuScreen());
            }
            if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Escape))
            {
                Game1.Instance.Exit();
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            for (int i = 0; i < Rectangles.Length; i++)
            {
                spriteBatch.Draw(boxTexture, Rectangles[i], Color.Black);
                Vector2 textSize = _font.MeasureString(menuLabels[i]);
                spriteBatch.DrawString(_font, menuLabels[i], new Vector2(Rectangles[i].X + (Rectangles[i].Width - textSize.X) / 2, 
                Rectangles[i].Y + (Rectangles[i].Height - textSize.Y) / 2), Color.White);
            }
        }
    }

