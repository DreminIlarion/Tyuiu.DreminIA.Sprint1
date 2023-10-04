using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DreminIA.Sprint1.Task2.V0.Lib
{
    public class DataService : ISprint1Task2V11
    {
        public static int CalculateSeconds(int hours, int minutes)
        {
            int totalSeconds = hours * 3600 + minutes * 60;
            return totalSeconds;
        }
    }
}
