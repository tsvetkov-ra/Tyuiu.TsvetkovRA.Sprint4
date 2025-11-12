using Tyuiu.TsvetkovRA.Sprint4.Task1.V19.Lib;

namespace Tyuiu.TsvetkovRA.Sprint4.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 1, 4, 5, 3, 5, 4, 4, 6, 2, 1, 1, 2 };
            int res = ds.Calculate(numsArray);
            int wait = 22;
            Assert.AreEqual(res, wait);

        }
    }
}
