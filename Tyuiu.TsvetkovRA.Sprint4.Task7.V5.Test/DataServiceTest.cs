using Tyuiu.TsvetkovRA.Sprint4.Task7.V5.Lib;
namespace Tyuiu.TsvetkovRA.Sprint4.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 3;
            string value = "246813579";
            int res = ds.Calculate(n, m, value);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
