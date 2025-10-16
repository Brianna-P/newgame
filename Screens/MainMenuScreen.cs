using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using newgame.Core;
namespace newgame.Screens;


    public class MainMenuScreen : Screen
    {
        private SpriteFont _font;
        private Vector2 playerPosition;

        public override void LoadContent()
        {
            _font = Game1.Instance.Content.Load<SpriteFont>("File");
            playerPosition = new Vector2(Game1.Instance.width / 2, Game1.Instance.height / 2);
        }

        public override void Update(GameTime gameTime)
        {
            // Example: press Escape to go back to StartScreen

            if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Escape))
            {
                //ScreenManager.ChangeScreen(new TitleScreen());
            }


            //Handle Player arrow key movement
            if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Left))
            {
                // Move player left
                playerPosition.X -= 5f; // Move left by 5 units
            }
            else if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Right))
            {
                // Move player right
                playerPosition.X += 5f; // Move right by 5 units
            }
            else if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Up))
            {
                // Move player up
                playerPosition.Y -= 5f; // Move up by 5 units
            }
            else if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Down))
            {
                // Move player down
                playerPosition.Y += 5f; // Move down by 5 units
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(_font, "Main Screen. ", new Vector2(100, 100), Color.White);
            spriteBatch.DrawString(_font, "Player Position: " + playerPosition.ToString(), playerPosition, Color.White);
        }
    }

