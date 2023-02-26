using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TargetsMG.Sprites
{
	public class Player : Sprite
	{
		public Player(Texture2D texture)
			: base(texture)
		{

		}

        public override void Update(GameTime gameTime)
        {
			var velocity = new Vector2();
			var speed = 2.5f;

			if (Keyboard.GetState().IsKeyDown(Keys.W))
			{
				velocity.Y = -speed;
			} else if (Keyboard.GetState().IsKeyDown(Keys.S))
			{
				velocity.Y = speed;
			}
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                velocity.X = -speed;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                velocity.X = speed;
            }

			Position += velocity;
        }
    }
}

