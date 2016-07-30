using System;
using System.IO;
namespace DarkFold.Frame.Core.Binary
{
	/// <summary>
	/// Binary loader.
	/// </summary>
	public class BinaryLoader:IDisposable
	{
		#region Fields
		/// <summary>
		/// The reader.
		/// </summary>
		private BinaryReader _reader;
		#endregion
		#region Constuctor
		/// <summary>
		/// Initializes a new instance of the <see cref="DarkFold.Frame.Core.BinaryLoader"/> class.
		/// </summary>
		/// <param name="path">Path.</param>
		public BinaryLoader (string path)
		{
			_reader = new BinaryReader (File.OpenRead (path));
		}
		#endregion
		#region Overrides
		/// <summary>
		/// Dispose this instance.
		/// </summary>
		public void Dispose()
		{
			_reader.Dispose ();
		}
		#endregion
		#region Load Methods
		/// <summary>
		/// Gets the byte.
		/// </summary>
		/// <returns>The byte.</returns>
		public byte GetByte()
		{
			return _reader.ReadByte ();
		}
		/// <summary>
		/// Gets the int.
		/// </summary>
		/// <returns>The int.</returns>
		public int GetInt()
		{
			return _reader.ReadInt32 ();
		}
		/// <summary>
		/// Gets the long.
		/// </summary>
		/// <returns>The long.</returns>
		public Int64 GetLong()
		{
			return _reader.ReadInt64 ();
		}
		/// <summary>
		/// Gets the string.
		/// </summary>
		/// <returns>The string.</returns>
		public string GetString()
		{
			return _reader.ReadString ();
		}
		/// <summary>
		/// Gets the bool.
		/// </summary>
		/// <returns><c>true</c>, if bool was gotten, <c>false</c> otherwise.</returns>
		public bool GetBool()
		{
			return _reader.ReadBoolean ();
		}
		#endregion
	}
}

