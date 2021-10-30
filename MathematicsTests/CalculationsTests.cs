using Mathematics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathematicsTests{
	[TestClass]
	public class CalculationsTests{
		[TestMethod]
		public void Sum_2and3_expected5(){
			//Arrange
			int a = 2, b = 3, expected = 5;
			//Act
			Calculations calculations = new Calculations();
			int actual = calculations.Sum(a, b);
			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Max_2and3_expected3(){
			int a = 2, b = 3;
			double expected = 3;
			Calculations calculations = new Calculations();
			double actual = calculations.Max(a, b);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void RectangleArea_3and5_expected15() => Assert.AreEqual(15, new Calculations().RectangleArea(3, 5));
	}
}