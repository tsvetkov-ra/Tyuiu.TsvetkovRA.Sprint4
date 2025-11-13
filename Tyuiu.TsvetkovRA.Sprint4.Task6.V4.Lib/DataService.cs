using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TsvetkovRA.Sprint4.Task6.V4.Lib
{
    public class DataService : ISprint4Task6V4
    {
        public string[] Calculate(string[] array)
        {
            var shortStrings = new List<string>();

            Array.ForEach(array, item =>
            {
                if (item.Length < 7)
                {
                    shortStrings.Add(item);
                }
            });

            return shortStrings.ToArray();
        }
    }
}
