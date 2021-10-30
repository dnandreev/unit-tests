using System;
using System.Text.RegularExpressions;

namespace UserRegistration{
	public static class PasswordStrengthChecker{
		public static int GetPasswordStrength(string password){
			if(string.IsNullOrEmpty(password))
				return 0;
			int result = 0;
			if(Math.Max(password.Length, 7) > 7)
				result++;
			if(Regex.Match(password, "[a-z]").Success)
				result++;
			if(Regex.Match(password, "[A-Z]").Success)
				result++;
			if(Regex.Match(password, "[0-9]").Success)
				result++;
			if(Regex.Match(password, "[\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)\\{\\}\\[\\]\\:\\'\\;\\\"\\/\\?\\.\\>\\,\\<\\~\\`\\-\\\\_\\=\\+\\|]").Success)
				result++;
			return result;
		}
	}
}