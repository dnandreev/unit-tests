using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTests{
	[TestClass] public class PasswordStrengthCheckerTests{
		[TestMethod] public void GetPasswordStrength_AllChars_5Points() => Assert.AreEqual(5, PasswordStrengthChecker.GetPasswordStrength("P2ssw0rd#"));

		[TestMethod] public void GetPasswordStrength_UpperCase_3Points() => Assert.AreEqual(3, PasswordStrengthChecker.GetPasswordStrength("Password"));

		[TestMethod] public void GetPasswordStrength_ContainsNumber_0_4Points() => Assert.AreEqual(4, PasswordStrengthChecker.GetPasswordStrength("Passw0rd"));

		[TestMethod] public void GetPasswordStrength_ContainsNumber_1_4Points() => Assert.AreEqual(4, PasswordStrengthChecker.GetPasswordStrength("Passw1rd"));

		[TestMethod] public void GetPasswordStrength_ContainsSpecialChar_At_5Points() => Assert.AreEqual(5, PasswordStrengthChecker.GetPasswordStrength("Passw0rd@"));

		[TestMethod] public void GetPasswordStrength_ContainsSpecialChar_Hash_5Points() => Assert.AreEqual(5, PasswordStrengthChecker.GetPasswordStrength("Passw0rd#"));

		[TestMethod] public void GetPasswordStrength_ContainsSpecialChar_Excl_5Points() => Assert.AreEqual(5, PasswordStrengthChecker.GetPasswordStrength("Passw0rd!"));

		[TestMethod] public void GetPasswordStrength_ContainsSpecialChar_Doll_5Points() => Assert.AreEqual(5, PasswordStrengthChecker.GetPasswordStrength("Passw0rd$"));
	}
}