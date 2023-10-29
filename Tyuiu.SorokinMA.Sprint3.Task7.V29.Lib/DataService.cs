using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SorokinMA.Sprint3.Task7.V29.Lib
{
    public class DataService : ISprint3Task7V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] a;
            int l = (stopValue - startValue) + 1;
            a = new double[l];
            double y;
            int k = 0;
            for (int x = startValue;x <=stopValue;x++)
            {
                if ((Math.Cos(x)- 2*x)==0)
                {
                    a[k] = 0;
                    continue;
                }
                y = Math.Round(((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - 6, 2);
                a[k] = y;
                k++;
            }
            return a;
        }
    }
}
