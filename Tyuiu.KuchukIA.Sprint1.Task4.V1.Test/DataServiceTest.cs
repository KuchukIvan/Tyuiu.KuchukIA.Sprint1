using Tyuiu.KuchukIA.Sprint1.Task4.V1.Lib;
namespace Tyuiu.KuchukIA.Sprint1.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            var wait = 0.028;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);

        }
    }
}
