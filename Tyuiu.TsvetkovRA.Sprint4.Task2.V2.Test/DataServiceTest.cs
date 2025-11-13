using Tyuiu.TsvetkovRA.Sprint4.Task2.V2.Lib;
namespace Tyuiu.TsvetkovRA.Sprint4.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 7, 4 };
            int res = ds.Calculate(array);
            int wait = 7;
            Assert.AreEqual(wait, res);
        }
    }
}
