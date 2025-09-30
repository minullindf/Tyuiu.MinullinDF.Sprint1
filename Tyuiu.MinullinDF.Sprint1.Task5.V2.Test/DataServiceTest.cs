using Tyuiu.MinullinDF.Sprint1.Task5.V2.Lib;
namespace Tyuiu.MinullinDF.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double far = 451;
            var cel = ds.FahrenheitToСelsius(far);
            Assert.AreEqual(233, cel);
        }
    }
}
