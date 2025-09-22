using Tyuiu.KuchukIA.Sprint1.Task5.V7.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток        *");
        Console.WriteLine("* до того момента (в первой половине дня), когда часовая стрелка          *");
        Console.WriteLine("* повернулась на f градусов(0 < f < 360, f – вещественное число).         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double f;
        Console.WriteLine("Введите значение f:");
        f = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("h = " + ds.AngleToHoursMinutes(f));

        Console.ReadKey();

    }
}