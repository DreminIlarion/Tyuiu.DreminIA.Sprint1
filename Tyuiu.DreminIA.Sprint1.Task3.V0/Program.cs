using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DreminIA.Sprint1.Task3.V0.Lib;


namespace Tyuiu.DreminIA.Sprint1.Task3.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите временной интервал (в минутах) -> ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            TimeSpan timeSpan = TimeSpan.FromMinutes(minutes);
            int hours = timeSpan.Hours;
            int remainingMinutes = timeSpan.Minutes;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("{0} минут — это {1} ч. {2} мин.",
                              minutes, hours, remainingMinutes.ToString("D2"));

            Console.ReadLine();

        }
    }
}
