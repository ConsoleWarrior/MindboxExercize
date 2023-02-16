namespace FigureLibrary.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CalculateSquare_Sides_5_12_13_expected_30()
        {
            //arrange
            double a = 5; double b = 12; double c = 13;
            double expected = 30;
            //act
            IFigure ten = new Triangle(a,b,c);
            double actual = ten.CalculateSquare();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckForSquareness_Sides_5_12_13_expected_true()
        {
            //arrange
            double a = 5; double b = 12; double c = 13;
            bool expected = true;
            //act
            Triangle ten = new Triangle(a, b, c);
            bool actual = ten.CheckForSquareness();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}