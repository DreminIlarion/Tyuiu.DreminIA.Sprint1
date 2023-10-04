using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DreminIA.Sprint1.Task5.V0.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public static double CalculateHours(double angle)
        {
            double hours = (angle / 360) * 12;
            return hours;
        }
    }
}
