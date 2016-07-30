using System;
using System.IO;

namespace DarkFold.Frame.Core.Binary
{
	/// <summary>
	/// Binary saver.
	/// </summary>
	public class BinarySaver:IDisposable
	{
		#region Fields
		/// <summary>
		/// The writer.
		/// </summary>
		private BinaryWriter _writer;
		#endregion
		#region Constuctor
		/// <summary>
		/// Initializes a new instance of the <see cref="DarkFold.Frame.Core.BinarySaver"/> class.
		/// </summary>
		/// <param name="path">Path.</param>
		public BinarySaver (string path)
		{
			_writer = new BinaryWriter (File.OpenWrite (path));
		}
		#endregion
		#region Overrides
		/// <summary>
		/// Releases all resource used by the <see cref="DarkFold.Frame.Core.BinarySaver"/> object.
		/// </summary>
		/// <remarks>Call <see cref="Dispose"/> when you are finished using the <see cref="DarkFold.Frame.Core.BinarySaver"/>. The
		/// <see cref="Dispose"/> method leaves the <see cref="DarkFold.Frame.Core.BinarySaver"/> in an unusable state. After
		/// calling <see cref="Dispose"/>, you must release all references to the
		/// <see cref="DarkFold.Frame.Core.BinarySaver"/> so the garbage collector can reclaim the memory that the
		/// <see cref="DarkFold.Frame.Core.BinarySaver"/> was occupying.</remarks>
		public void Dispose()
		{
			_writer.Dispose ();
		}
		#endregion
		#region Write Methods
		/// <summary>
		/// Write the specified val.
		/// </summary>
		/// <param name="val">Value.</param>
		public void Write(int val)
		{
			_writer.Write (val);
		}
		/// <summary>
		/// Write the specified val.
		/// </summary>
		/// <param name="val">Value.</param>
		public void Write(byte val)
		{
			_writer.Write (val);
		}
		/// <summary>
		/// Write the specified val.
		/// </summary>
		/// <param name="val">Value.</param>
		public void Write(string val)
		{
			_writer.Write (val);
		}
		/// <summary>
		/// Write the specified val.
		/// </summary>
		/// <param name="val">Value.</param>
		public void Write(Int64 val)
		{
			_writer.Write (val);
		}
		/// <summary>
		/// Write the specified val.
		/// </summary>
		/// <param name="val">If set to <c>true</c> value.</param>
		public void Write(bool val)
		{
			_writer.Write (val);
		}
		#endregion
	}
}

