using Tyuiu.TsvetkovRA.Sprint4.Task6.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Дан строковый массив данных, используя класс Array, выведите элементы   *");
        Console.WriteLine(" *массива, длина которых меньше 7 символов.                               *");
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Строковый массив: " + "[Москва,  Cанкт Петербург, Новосибирск, Екатеринбург, Нижний Новгород, Казахстан, Самара]");
        var array  = new string[] { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
        Console.WriteLine(ds.Calculate(array));
        Console.ReadKey();
    }

}