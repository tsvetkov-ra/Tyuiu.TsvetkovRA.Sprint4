using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TsvetkovRA.Sprint4.Task3.V4.Lib
{
    public class DataService : ISprint4Task3V4
    {
        public int Calculate(int[,] array)
        {
            
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;
            int min = array[0, 4];
            for (int i = 1; i < 5; i++)
            {
                if (array[i, 4] < min)
                {
                    min = array[i, 4];
                }
            }
            return min;

        }
    }
}
