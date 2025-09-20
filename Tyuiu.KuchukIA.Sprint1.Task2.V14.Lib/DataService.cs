using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KuchukIA.Sprint1.Task2.V14.Lib
{
    public class DataService : ISprint1Task2V14
    {
        public int ConvertKelvinToCelsius(int value)
        {
            return (int)(value - 273.15);
        }
    }
}
