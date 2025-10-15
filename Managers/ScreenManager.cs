using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using newgame.Screens;
namespace newgame.Core;

public static class ScreenManager
{
    private static Screen _currentScreen;

    // Switch to a new screen
    public static void ChangeScreen(Screen newScreen)
    {
        _currentScreen?.UnloadContent();
        _currentScreen = newScreen;
        _currentScreen.LoadContent();
    }

    public static void Update(GameTime gameTime)
    {
        _currentScreen?.Update(gameTime);
    }

    public static void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        _currentScreen?.Draw(gameTime, spriteBatch);
    }
}

