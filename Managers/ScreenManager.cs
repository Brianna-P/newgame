using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using newgame.Screens; 
using System.Collections.Generic;
namespace newgame.Core;

public static class ScreenManager
{
    private static Screen _currentScreen;
    private static Stack<Screen> _screenStack = new Stack<Screen>(); //Stack to hold previous screens

    public static void PushScreen(Screen newScreen)
    {
        _screenStack.Push(newScreen);
        newScreen.LoadContent();
    }

    public static void PopScreen()
    {
        if (_screenStack.Count > 0)
        {
            var top = _screenStack.Pop();
            top.UnloadContent();
        }
    }
    // Switch to a new screen
    public static void ChangeScreen(Screen newScreen)
    {
        while (_screenStack.Count > 0)
            _screenStack.Pop().UnloadContent();

        _screenStack.Push(newScreen);
        newScreen.LoadContent();
    }

    public static void Update(GameTime gameTime)
    {
        if (_screenStack.Count > 0) 
        _screenStack.Peek().Update(gameTime);
    }

    public static void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        if (_screenStack.Count > 0)
        _screenStack.Peek().Draw(gameTime, spriteBatch);
    }
}

