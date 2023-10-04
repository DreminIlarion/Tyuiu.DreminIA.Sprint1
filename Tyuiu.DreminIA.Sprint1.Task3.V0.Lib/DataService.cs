using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DreminIA.Sprint1.Task3.V0.Lib
{
    public class DataService : ISprint1Task3V9
    {
        public static string ConvertToHoursAndMinutes(int minutes)
        {
            TimeSpan timeSpan = TimeSpan.FromMinutes(minutes);
            int hours = timeSpan.Hours;
            int remainingMinutes = timeSpan.Minutes;

            return string.Format("{0} ч. {1} мин.",
                                 hours, remainingMinutes.ToString("D2"));
        }
    }
}
