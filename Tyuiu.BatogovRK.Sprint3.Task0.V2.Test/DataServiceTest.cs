using Tyuiu.BatogovRK.Sprint3.Task0.V2.Lib;

namespace Tyuiu.BatogovRK.Sprint3.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.021, ds.GetMultiplySeries(1, 9));
        }
    }
}
