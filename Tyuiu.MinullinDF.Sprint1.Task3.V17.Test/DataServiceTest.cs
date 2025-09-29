using Tyuiu.MinullinDF.Sprint1.Task3.V17.Lib;
namespace Tyuiu.MinullinDF.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.01;
            var res = ds.ZeroCheck(x);
            Assert.AreEqual(true, res);
        }
    }
}
