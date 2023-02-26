using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TargetsMG.Sprites;

namespace TargetsMG.Core
{
	public class Camera
	{
		public Matrix Transform { get; private set; }

		public void Follow(Sprite target)
		{
			// position x offset by screen size
			Transform = Matrix.CreateTranslation(
				-target.Position.X - (target.Rectangle.Width /2),
				-target.Position.Y - (target.Rectangle.Height /2),
				0) * Matrix.CreateTranslation(
					Game1.ScreenWidth /2,
					Game1.ScreenHeight /2,
					0);
		}
	}
}

