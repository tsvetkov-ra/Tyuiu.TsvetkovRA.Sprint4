using Tyuiu.TsvetkovRA.Sprint4.Task2.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* подсчитать произведение нечетных элементов случайного массива           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите длину массива:");
        int len;
        len = Convert.ToInt32(Console.ReadLine());
        int[] numsArray = new int[len];
        for (int i = 0; i <= len - 1; i++)
        {
            numsArray[i] = rnd.Next(1, 9);
        }
        Console.WriteLine("Массив");
        for (int i = 0; i <= numsArray.Length - 1; i++)
        {
            Console.WriteLine(numsArray[i] + '\t');
        }
        int res = ds.Calculate(numsArray);
        Console.WriteLine("Результат:"  + res);
        Console.ReadKey();
    }
}