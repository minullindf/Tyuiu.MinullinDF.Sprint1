using Tyuiu.MinullinDF.Sprint1.Task6.V2.Lib;
namespace Tyuiu.MinullinDF.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string text = "Hello world!";
            var res = ds.CheckHello(text);
            Assert.AreEqual(true, res);
        }
    }
}
