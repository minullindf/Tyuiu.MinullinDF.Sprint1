using Tyuiu.MinullinDF.Sprint1.Task2.V7.Lib;

namespace Tyuiu.MinullinDF.Sprint1.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.CalculateSquareCircle(x);
            Assert.AreEqual(3.142, res);
        }
    }
}
