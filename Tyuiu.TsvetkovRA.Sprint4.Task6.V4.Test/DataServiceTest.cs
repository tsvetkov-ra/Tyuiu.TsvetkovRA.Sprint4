using Tyuiu.TsvetkovRA.Sprint4.Task6.V4.Lib;
namespace Tyuiu.TsvetkovRA.Sprint4.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds  = new DataService();
            string[] strings = { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
            string[] res = ds.Calculate(strings);
            string[] wiat = { "Москва", "Самара" };
            CollectionAssert.AreEqual(res, wiat);
        }
    }
}
