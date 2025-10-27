using Tyuiu.BatogovRK.Sprint3.Task7.v23.Lib;

namespace Tyuiu.BatogovRK.Sprint3.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startvalue = -5;
            int stopvalue = 5;
            int len = stopvalue - startvalue + 1;
            double[] valuewaitarray;
            valuewaitarray = new double[len];
            valuewaitarray[0] = 13.81;
            valuewaitarray[1] = 11.87;
            valuewaitarray[2] = 9.87;
            valuewaitarray[3] = 7.74;
            valuewaitarray[4] = 5.36;
            valuewaitarray[5] = 2.50;
            valuewaitarray[6] = 0;
            valuewaitarray[7] = 0.79;
            valuewaitarray[8] = -1.75;
            valuewaitarray[9] = -3.78;
            valuewaitarray[10] = -5.71;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startvalue, stopvalue);
            CollectionAssert.AreEqual(res, valuewaitarray);
        }
    }
}
