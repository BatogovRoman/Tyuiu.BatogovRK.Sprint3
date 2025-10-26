using Tyuiu.BatogovRK.Sprint3.Task3.V14.Lib;

namespace Tyuiu.BatogovRK.Sprint3.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "dgt ghedd bed";
            char replaceable = 'd';
            char replacement = '’';

            string res = ds.ReplaceCharInString(value, replaceable, replacement);
            string wait = "'gt ghe'' be'";
            Assert.AreEqual(wait, res);
        }
    }
}
