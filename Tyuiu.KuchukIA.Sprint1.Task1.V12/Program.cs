using Tyuiu.KuchukIA.Sprint1.Task1.V12.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #0                                                              *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу на C#, которая запрашивает у пользователя *");
        Console.WriteLine("* исходные данные, вычисляет результат по формуле  (x+y)/6                *");
        Console.WriteLine("* и печатает его на экране.                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x, y;
        Console.WriteLine("Введите значение x:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение y:");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadKey();
     
    }
}