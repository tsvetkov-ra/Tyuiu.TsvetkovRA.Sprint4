using Tyuiu.TsvetkovRA.Sprint4.Task5.V10.Lib;
namespace Tyuiu.TsvetkovRA.Sprint4.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { -1, -2, -2, -3, 4 }, { 1, -3, -4, -5, -6 }, { 2, -3, -4, -5, -6 }, { 3, -1, -1, -2, -3 }, {-1,-2,-3,4,-4 } };
            int wait = 14;
            int res = ds.Calculate(matrix);
            Assert.AreEqual(res, wait);

        }
    }
}
