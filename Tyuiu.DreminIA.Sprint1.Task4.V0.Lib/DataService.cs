using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DreminIA.Sprint1.Task4.V0.Lib
{
    public class DataService : ISprint1Task4V25
    {
        public static double CalculateResult(double alpha)
        {
            double result = (1 - Math.Cos(alpha)) / Math.Pow(Math.Sin(alpha), 2);
            return Math.Round(result, 3);
        }
    }
}
