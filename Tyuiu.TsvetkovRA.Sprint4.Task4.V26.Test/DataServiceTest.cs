using Tyuiu.TsvetkovRA.Sprint4.Task4.V26.Lib;
namespace Tyuiu.TsvetkovRA.Sprint4.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 5, 4, 1, 1, 2, }, { 3, 2, 4, 3, 5 }, { 5, 2, 3, 2, 2, }, { 2, 5, 1, 1, 4, }, { 5, 3, 4, 3, 2 } };
            int[,] res = ds.Calculate(matrix);
            int[,] waitres = new int[5, 5] { { 0, 4, 0, 0, 2, }, { 0, 2, 4, 0, 0 }, { 0, 2, 0, 2, 2, }, { 2, 0, 0, 0, 4, }, { 0, 0, 4, 0, 2 } };
            CollectionAssert.AreEqual(res, waitres);

        }
    }
}
