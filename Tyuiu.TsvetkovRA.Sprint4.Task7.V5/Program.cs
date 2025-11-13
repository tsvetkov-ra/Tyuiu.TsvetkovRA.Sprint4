using Tyuiu.TsvetkovRA.Sprint4.Task7.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();
        string var = "246813579";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"246813579\".                        *");
        Console.WriteLine(" *Преобразуйте ее в матрицу 3 на 3 и подсчитайте количество четных чисел. *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Строка чисел :" + var);
        int res = ds.Calculate( 3, 3, var);
        Console.WriteLine("Результат :" + res);
        Console.ReadKey();
    }
}