using Tyuiu.KuchukIA.Sprint1.Task3.V12.Lib;
namespace Tyuiu.KuchukIA.Sprint1.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double kat1 = 3;
            double kat2 = 7;
            var res = ds.TriangleArea(kat1, kat2);
            Assert.AreEqual(10.5, res);
        }
    }
}
