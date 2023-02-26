using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TargetsMG.Sprites
{
	public class Sprite : Component
	{
		protected Texture2D _texture;
		public Vector2 Position { get; set; }
		public Rectangle Rectangle
		{
			get {
				    return new Rectangle((int)Position.X, (int)Position.Y, _texture.Width, _texture.Height);
				}
		}
        
        public Sprite(Texture2D texture)
        {
            _texture = texture;
        }

        public override void Draw(GameTime gameTime, SpriteBatch sprite)
        {
			sprite.Draw(_texture, Position, Color.White);
        }

        public override void Update(GameTime gameTime)
        {
            
        }


    }
}

