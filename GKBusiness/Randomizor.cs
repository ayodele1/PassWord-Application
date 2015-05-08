
using System;
using System.Text;
namespace GKBusiness
{

	/// <summary>
	/// Helper class for generating random strings
	/// </summary>
	public static class Randomizor
	{
		#region Non-Public Data Members
		private static Random _random = new Random(Environment.TickCount);
		#endregion

		#region Non_public Properties/Methods
		public static string GetString(int length)
		{
			string chars = "0123456789abcdefghijklmnopqrstuvwxyz";
			StringBuilder builder = new StringBuilder(length);

			for (int i = 0; i < length; ++i)
				builder.Append(chars[_random.Next(chars.Length)]);

			return builder.ToString();
		}
		#endregion

		#region Public Interface
		public static string GenerateString()
		{
			return GetString(_random.Next(10, 50));
		}

		public static string GenerateString(int length)
		{
			return GetString(length);
		}
		#endregion
	}
}
