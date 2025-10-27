
using Tyuiu.BatogovRK.Sprint3.Task5.V4.Lib;

namespace Tyuiu.BatogovRK.Sprint3.Task5.V4.Test
{
    public class Tests
    {
        public void Test1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.GetSumSumSeries(5, 1, 1, 3, 13), 3328.185);
        }
    }
}