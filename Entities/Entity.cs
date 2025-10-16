using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



//Abstract base class for all game entities
namespace newgame.Entities{
    
    public abstract class Entity{
        public Vector2 position;
        public Texture2D texture;

        public virtual void LoadContent(){}
        public virtual void Update(GameTime gameTime){}
        public virtual void Draw(SpriteBatch spriteBatch){
            if(texture != null){
                spriteBatch.Draw(texture, position, Color.White);
            }
        }


    }

}