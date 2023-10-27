﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SorokinMA.Sprint3.Task4.V3.Lib
{
    public class DataService : ISprint3Task4V3
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;
            for (int x = startValue; x<=stopValue; x++)
            {
                if (x == 0) break;
                    sum = sum + (Math.Cos(x) + Math.Sin(x)) / x;
            }
            return Math.Round(sum,3);
        }
    }
}
