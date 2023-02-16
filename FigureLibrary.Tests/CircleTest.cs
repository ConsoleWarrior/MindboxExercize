namespace FigureLibrary.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateSquare_radius_10()
        {
            //arrange
            double radius = 10;
            double expected = 314.1592653589793;
            //act
            Circle ten = new Circle(radius);
            double actual = ten.CalculateSquare();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}