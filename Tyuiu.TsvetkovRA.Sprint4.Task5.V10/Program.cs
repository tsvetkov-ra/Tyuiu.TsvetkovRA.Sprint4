using Tyuiu.TsvetkovRA.Sprint4.Task5.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
       DataService ds = new DataService();
        int[,] matrix = new int[5, 5];
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("*случайными значениями в диапазоне от -4 до 7.                            *");
        Console.WriteLine("* Найти сумму положительных элементов                                     *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = rnd.Next(-4,7);
            }
        }
        Console.WriteLine("*Массив: *");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(matrix[i,j]);
            }
        }
        int res = ds.Calculate(matrix);
        Console.WriteLine("Результат: "  + res);

    }
}