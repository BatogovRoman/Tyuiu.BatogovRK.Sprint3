using Tyuiu.BatogovRK.Sprint3.Task1.V27.Lib;

namespace Tyuiu.BatogovRK.Sprint3.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double n = 0.75;
            int startValue = 1, stopValue = 5;
            var proiz = ds.GetMultiplySeries(n, startValue, stopValue);
            double wait = 419028.1;

            Assert.AreEqual(wait, proiz);
        }
    }
}
