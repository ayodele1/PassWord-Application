namespace GKBusiness
{
	/// <summary>
	/// Authenticates a Given TextBox
	/// </summary>
	public static class AuthenticationMgr
	{
		public static bool Validate(string text)
		{
			if (string.IsNullOrEmpty(text))
				return false;
			return true;
		}

	}
}
