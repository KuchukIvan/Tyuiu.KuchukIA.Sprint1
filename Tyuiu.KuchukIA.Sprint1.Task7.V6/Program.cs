using Tyuiu.KuchukIA.Sprint1.Task7.V6.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*              x      2                                                   *");
        Console.WriteLine("* (  1 +  1   )  - 12x  y                                                 *");
        Console.WriteLine("* (      ---  )                                                           *");
        Console.WriteLine("* (        2  )                                                           *");
        Console.WriteLine("* (       x   )                                                           *");
   
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x, y;

        Console.WriteLine("Введите x:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите y:");
        y = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));

        Console.ReadKey();

    }
}