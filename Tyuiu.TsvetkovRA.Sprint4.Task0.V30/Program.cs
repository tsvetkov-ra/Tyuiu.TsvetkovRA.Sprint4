using Tyuiu.TsvetkovRA.Sprint4.Task0.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* подсчитать сумму четных элементов массива                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        
        DataService ds = new DataService();
        int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i <= numsArray.Length - 1; i++)
        {
            Console.WriteLine(numsArray[i]+"\t");

        }
        int res = ds.GetSumEvenArrEl(numsArray);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);

    }


}