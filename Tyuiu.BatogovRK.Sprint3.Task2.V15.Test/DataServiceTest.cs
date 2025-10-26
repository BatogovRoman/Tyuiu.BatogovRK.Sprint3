using Tyuiu.BatogovRK.Sprint3.Task2.V15.Lib;

namespace Tyuiu.BatogovRK.Sprint3.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int Start = 1;
            int End = 20;
            double wait = 0.298;

            double res = ds.GetSumSeries(a, Start, End);
            Assert.AreEqual(wait, res);
        }
    }
}
