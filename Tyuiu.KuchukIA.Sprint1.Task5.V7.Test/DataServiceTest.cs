using Tyuiu.KuchukIA.Sprint1.Task5.V7.Lib;
namespace Tyuiu.KuchukIA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 257;
            var wait = 8;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(wait, res);
        }
    }
}
