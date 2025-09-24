using Tyuiu.KuchukIA.Sprint1.Task7.V6.Lib;
namespace Tyuiu.KuchukIA.Sprint1.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var wait = -142.438;
            var res = ds.Calculate(x, y);
        }
    }
}
