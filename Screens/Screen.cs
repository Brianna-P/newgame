using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using newgame.Core;
namespace newgame.Screens;

public abstract class Screen
{
    // Called once when the screen is loaded
    public virtual void LoadContent() { }

    // Called when the screen is unloaded
    public virtual void UnloadContent() { }

    // Called every frame to update logic
    public abstract void Update(GameTime gameTime);

    // Called every frame to draw
    public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
}

