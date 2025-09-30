using Tyuiu.MinullinDF.Sprint1.Task4.V11.Lib;
namespace Tyuiu.MinullinDF.Sprint1.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 1;
            double y = 0;
            DataService ds = new DataService();
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.785, res);
        }
    }
}
