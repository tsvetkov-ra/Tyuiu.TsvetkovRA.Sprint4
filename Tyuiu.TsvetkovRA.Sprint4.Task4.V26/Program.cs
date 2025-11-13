using Tyuiu.TsvetkovRA.Sprint4.Task4.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]; 
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("*статическими значениями в диапазоне от 1 до 8.                           *");
        Console.WriteLine("*Найдите минимальный элемент в последнем столбце массива.                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите количество строк");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        int colums = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значения от 1 до 5");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                matrix[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Ваша матрица :");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.WriteLine($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
        int[,] res = ds.Calculate(matrix);
        Console.WriteLine("\nРезультат:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.WriteLine($"{res[i,j]} \t");
            }
            Console.WriteLine();
        }

    }
}