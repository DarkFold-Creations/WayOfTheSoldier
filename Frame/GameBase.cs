using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
namespace DarkFold.Frame.Core
{
	/// <summary>
	/// Game base.
	/// </summary>
	public class GameBase:Game
	{
		#region Fields
		/// <summary>
		/// The Sprite batch.
		/// </summary>
		protected SpriteBatch _batch;
		public static GraphicsDeviceManager GraphicsDeviceManager;
		public new static GraphicsDevice GraphicsDevice {
			get {
				return GraphicsDeviceManager.GraphicsDevice;
			}
		}
		#endregion
		#region Constuctor
		/// <summary>
		/// Initializes a new instance of the <see cref="DarkFold.Frame.Core.GameBase"/> class.
		/// </summary>
		public GameBase ()
		{
			#if DEBUG
			this.IsMouseVisible=true;
			#endif
		}
		#endregion
		#region Overrides
		protected override void Draw (GameTime gameTime)
		{
			base.Draw (gameTime);
		}
		protected override void Update (GameTime gameTime)
		{
			base.Update (gameTime);
		}
		protected override void LoadContent ()
		{
			base.LoadContent ();
			_batch = new SpriteBatch (GraphicsDevice);
		}
		protected override void Initialize ()
		{
			base.Initialize ();

		}
		#endregion
		#region Custom Methods
		public SpriteBatch GetBatch()
		{
			return _batch;
		}
		#endregion
	}
}

