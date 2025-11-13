using Tyuiu.TsvetkovRA.Sprint4.Task3.V4.Lib;
namespace Tyuiu.TsvetkovRA.Sprint4.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService  ds = new DataService();
            int[,] mas = new int[5, 5] { { 6, 2, 4, 1, 5 }, { 8, 2, 3, 4, 2 }, {3, 7, 7, 1, 3 }, {3, 4, 8, 1, 3 }, {4, 3, 5, 5, 2 } };
            int res = ds.Calculate(mas);
            int wait = 2;
            Assert.AreEqual(wait, res);

        }
    }
}
