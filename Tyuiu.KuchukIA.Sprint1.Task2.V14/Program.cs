using Tyuiu.KuchukIA.Sprint1.Task2.V14.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #14                                                              *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Известна температура в градусах Кельвина.                               *");
        Console.WriteLine("* Перевести температуру в градусы Цельсия.                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x;
        Console.WriteLine("Введите значение x:");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Температура в градусах Цельсия равна: " + ds.ConvertKelvinToCelsius(x));
        Console.ReadKey();

    }
}