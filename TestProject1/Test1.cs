using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int startvalue = -5;
            int stopvalue = 5;
            int len = stopvalue - startvalue + 1;
            double[] valuewaitarray;
            valuewaitarray = new double[len];
            valuewaitarray[0] = 59.49;
            valuewaitarray[1] = 38.47;
            valuewaitarray[2] = -2.81;
            valuewaitarray[3] = -19.67;
            valuewaitarray[4] = -8.42;
            valuewaitarray[5] = 0.57;
            valuewaitarray[6] = -6.30;
            valuewaitarray[7] = -20.14;
            valuewaitarray[8] = -3.51;
            valuewaitarray[9] = 38.13;
            valuewaitarray[10] = 59.60;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startvalue, stopvalue);
            CollectionAssert.AreEqual(res, valuewaitarray);
        }
    }
}
