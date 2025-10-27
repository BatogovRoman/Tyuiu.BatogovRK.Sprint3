
using Tyuiu.BatogovRK.Sprint3.Task4.V23.Lib;

namespace Tyuiu.BatogovRK.Sprint3.Task4.V23.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int x = -5, y = 5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(244.656, res);
        }
    }
}
