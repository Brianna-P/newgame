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
        private int labelIndex = 0;

        public override void LoadContent()
        {
            _font = Game1.Instance.Content.Load<SpriteFont>("File");
            boxTexture = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            boxTexture.SetData(new[] { Color.White });
        }

        public override void Update(GameTime gameTime)
        {
            // Track mouse position
            var mouseState = Microsoft.Xna.Framework.Input.Mouse.GetState();
            Point mousePosition = new Point(mouseState.X, mouseState.Y);
            

            //Hover menu item
            if(Rectangles[0].Contains(mousePosition)){
                labelIndex = 0;
            }
            else if(Rectangles[1].Contains(mousePosition)){
                labelIndex = 1;
            }

            //Mouse Click
            if (mouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed){
                if(Rectangles[0].Contains(mousePosition)){
                    ScreenManager.ChangeScreen(new MainMenuScreen());
                }
                if(Rectangles[1].Contains(mousePosition)){
                    Game1.Instance.Exit();
                }
            }

            //Handle Keyboard Menu List Navigation
            if(Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Up)){

                labelIndex--;
                if(labelIndex < 0) labelIndex = 0;

            }
            else if(Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Down)){

                labelIndex++;
                if(labelIndex > menuLabels.Length - 1) labelIndex = menuLabels.Length - 1;

            }
            // press Enter to go to MainMenuScreen
            if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Enter))
            {
                if(labelIndex == 0){
                    ScreenManager.ChangeScreen(new MainMenuScreen());
                }
                if(labelIndex == 1){
                    Game1.Instance.Exit();
                }
            }

        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //Loop through rectangles to draw the menu
            for (int i = 0; i < Rectangles.Length; i++)
            {
                //Pick the color based on hovered label
                Color boxColor = (i == labelIndex) ? Color.Gray : Color.Black;
                spriteBatch.Draw(boxTexture, Rectangles[i], boxColor);
                Vector2 textSize = _font.MeasureString(menuLabels[i]);
                spriteBatch.DrawString(_font, menuLabels[i], new Vector2(Rectangles[i].X + (Rectangles[i].Width - textSize.X) / 2, 
                Rectangles[i].Y + (Rectangles[i].Height - textSize.Y) / 2), Color.White);
            }
        }
    }

