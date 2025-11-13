using Tyuiu.TsvetkovRA.Sprint4.Task3.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds =  new DataService();
        int[,] array = new int[5,5] { { 6, 2, 4, 1, 5 }, { 8, 2, 3, 4, 2 }, { 3, 7, 7, 1, 3 }, { 3, 4, 8, 1, 3 }, { 4, 3, 5, 5, 2 } };
        int res = ds.Calculate(array);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("*статическими значениями в диапазоне от 1 до 8.                           *");
        Console.WriteLine("*Найдите минимальный элемент в последнем столбце массива.                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив : ");
        Console.WriteLine("6, 2, 4, 1, 5");
        Console.WriteLine("8, 2, 3, 4, 2");
        Console.WriteLine("3, 7, 7, 1, 3");
        Console.WriteLine("3, 4, 8, 1, 3");
        Console.WriteLine("4, 3, 5, 5, 2");
        Console.WriteLine("Минимальное число в последнем столбце = " + res);
    }
}