using System.Text;

namespace ServerManagement.Helpers;

public static class StringExtensions
{
	public static string ReplaceWhiteSpaceWithDashes(this string s)
	{
		StringBuilder sb = new StringBuilder(s.Trim().ToLowerInvariant());
		sb.Replace(" ", "-");
		return sb.ToString();
	}
}
