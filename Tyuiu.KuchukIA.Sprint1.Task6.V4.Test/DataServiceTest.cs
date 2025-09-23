using Tyuiu.KuchukIA.Sprint1.Task6.V4.Lib;
namespace Tyuiu.KuchukIA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string test = "искуственный интеллект, сделанный человеком";
            string wait = "искуственный, сделанный";
            var res = ds.CheckDoubleN(test);
            Assert.AreEqual(wait, res);
        }
    }
}
