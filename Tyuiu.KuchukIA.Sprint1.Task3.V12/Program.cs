using Tyuiu.KuchukIA.Sprint1.Task3.V12.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #12                                                              *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу для вычисления площади прямоугольного                *");
        Console.WriteLine("* треугольника по длинам двух катетов.                                    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double kat1;
        double kat2;

        Console.WriteLine("Введите значение первого катета: ");
        kat1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение второго катета: ");
        kat2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Площадь треугольника равна: " + ds.TriangleArea(kat1, kat2));

        Console.ReadKey();

    }
}