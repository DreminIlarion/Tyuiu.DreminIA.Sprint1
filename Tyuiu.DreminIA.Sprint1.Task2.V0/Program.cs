using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DreminIA.Sprint1.Task2.V0.Lib;



namespace Tyuiu.DreminIA.Sprint1.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество часов:");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество минут:");
            int minutes = int.Parse(Console.ReadLine());

            int seconds = CalculateSeconds(hours, minutes);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Количество секунд с начала суток: {seconds}");
        }

        static int CalculateSeconds(int hours, int minutes)
        {
            int totalSeconds = hours * 3600 + minutes * 60;
            return totalSeconds;
        }
    }
}
