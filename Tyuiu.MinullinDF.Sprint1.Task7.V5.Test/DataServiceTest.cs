using Tyuiu.MinullinDF.Sprint1.Task7.V5.Lib;
namespace Tyuiu.MinullinDF.Sprint1.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 2;
            DataService ds = new DataService();
            var res = ds.Calculate(x);
            Assert.AreEqual(-0.545, res);
        }
    }
}
