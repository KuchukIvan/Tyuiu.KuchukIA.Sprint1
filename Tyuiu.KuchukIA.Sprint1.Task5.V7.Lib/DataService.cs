﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KuchukIA.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            double h = Math.Floor(f / 30);
            int res = Convert.ToInt32(h);
            return res;
        }
    }
}
